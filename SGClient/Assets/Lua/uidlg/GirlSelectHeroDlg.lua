-- 界面
local m_Dlg = nil;
--local m_DialogFrameMod = nil;
local m_uiUIP_HeroHead = nil;
local m_uiOKBtn = nil;
local m_uiStar = nil;
local m_uiContent = nil;
local m_uiStarContent = nil;

local m_upHeroCache = {};
local m_CacheHeroCache = {};
local isFirst = true;
local preObj = nil;

local pGirl = nil;
local girlConifg = nil;

-- 打开界面
function GirlSelectHeroDlgOpen()
	m_Dlg = eye.uiManager:Open( "GirlSelectHeroDlg" );
	--m_DialogFrameMod = DialogFrameModOpen( m_Dlg, T(0), nil, GirlSelectHeroDlgClose );
end

-- 隐藏界面
function GirlSelectHeroDlgClose()
	if m_Dlg == nil then
		return;
	end
	--DialogFrameModClose( m_DialogFrameMod );
	--m_DialogFrameMod = nil;
	eye.uiManager:Close( "GirlSelectHeroDlg" );
end

-- 删除界面
function GirlSelectHeroDlgDestroy()
	GameObject.Destroy( m_Dlg );
	m_Dlg = nil;
end

----------------------------------------
-- 事件
----------------------------------------

-- 所属按钮点击时调用
function GirlSelectHeroDlgOnEvent( nType, nControlID, value, gameObject )
	if nType == UI_EVENT_CLICK then
        if nControlID == -1 then
            GirlSelectHeroDlgClose();
		elseif nControlID == 1 then
			
		-- 选择武将
		elseif nControlID > 1000 and nControlID < 2000 then
			GirlSelectHeroDlgSelectHero( nControlID - 1000 )
        end
	end
end

-- 载入时调用
function GirlSelectHeroDlgOnAwake( gameObject )
	-- 控件赋值	
	local objs = gameObject:GetComponent( typeof(UISystem) ).relatedGameObject;	
	m_uiUIP_HeroHead = objs[0];
	m_uiOKBtn = objs[1];
	m_uiStar = objs[2];
	m_uiContent = objs[3];
	m_uiStarContent = objs[4];
	
	-- 对象池
	m_ObjectPool = gameObject:GetComponent( typeof(ObjectPoolManager) );
	m_ObjectPool:CreatePool("UIP_HeroHead", 4, 4, m_uiUIP_HeroHead);
end

-- 界面初始化时调用
function GirlSelectHeroDlgOnStart( gameObject )
	
end

-- 界面显示时调用
function GirlSelectHeroDlgOnEnable( gameObject )
	
end

-- 界面隐藏时调用
function GirlSelectHeroDlgOnDisable( gameObject )
	isFirst = true;
end

-- 界面删除时调用
function GirlSelectHeroDlgOnDestroy( gameObject )
	m_Dlg = nil;
end

-- 每帧调用
function GirlSelectHeroDlgOnLogic( gameObject )
	
end


----------------------------------------
-- 自定
----------------------------------------
function GirlSelectHeroDlgShow(kind)
	GirlSelectHeroDlgOpen()
	pGirl = GetGirl():GetPtr(kind);
	local color = GetGirl():GetPtr(kind).m_color;
	girlConifg = girlconfig(kind,color);
	GirlPairHead();
end

function GirlPairHead()
	GirlSelectHeroDlgListClear();
	-- 主将进入临时缓存
	for offset = 0, 11, 1 do	
		local pHero = GetHero().m_CityHero[offset];
		if pHero ~= nil and pHero.m_kind > 0 then
			table.insert(m_upHeroCache, { m_kind = pHero.m_kind, m_pHero = pHero });
		end
	end
	
	-- 聚贤阁进临时缓存			
	for offset = 0, MAX_HERONUM-1, 1 do
		local pHero = GetHero().m_Hero[offset];
		if pHero ~= nil and pHero.m_kind > 0 then
			local base = pHero.m_attack_base+pHero.m_defense_base+pHero.m_troops_base;
			local wash = pHero.m_attack_wash+pHero.m_defense_wash+pHero.m_troops_wash;
			table.insert(m_CacheHeroCache, { m_kind = pHero.m_kind, m_pHero = pHero, total = base+wash });
		end
	end
	
	-- 排序
	table.sort( m_CacheHeroCache, HeroWashDlgQualtiySort );

	local num = #m_upHeroCache+#m_CacheHeroCache;
	for i=1, num, 1 do
		local pHero = nil
		if i <= #m_upHeroCache then
			pHero = m_upHeroCache[i].m_pHero;
		else
			pHero = m_CacheHeroCache[i-#m_upHeroCache].m_pHero;
		end
		local uiHeroObj = m_ObjectPool:Get( "UIP_HeroHead" );
		uiHeroObj.transform:SetParent( m_uiContent.transform );
		SetTrue( uiHeroObj )
		
		SetControlID( uiHeroObj, 1000+pHero.m_kind )
		local objs = uiHeroObj.transform:GetComponent( typeof(Reference) ).relatedGameObject;
		local uiShape = objs[0];
		local uiColor = objs[1];
		local uiFlag = objs[2];
		local uiName = objs[3];
		local uiSelect = objs[4];
		local uiCon = objs[5];
		SetTrue( uiCon )
		SetTrue( uiShape )
		SetTrue( uiColor )
		SetTrue( uiFlag )
		SetTrue( uiName )
		
		if isFirst then
			SetTrue( uiSelect )
			isFirst = false;
			preObj = uiHeroObj;
			ShowStar(pHero.m_kind);
		else
			SetFalse( uiSelect )
		end
		
		SetImage( uiShape, HeroHeadSprite( pHero.m_kind )  );
		SetImage( uiColor,  ItemColorSprite( pHero.m_color )  );
		SetText( uiName, HeroNameLv( pHero.m_kind, pHero.m_level ), NameColor(pHero.m_color) );
		if pHero.m_offset >= 1000 and pHero.m_offset < 1004 then
			SetText( uiFlag, T(2047) )
		elseif pHero.m_offset >= 1004 and pHero.m_offset < 1008 then
			SetText( uiFlag, T(2048) )
		elseif pHero.m_offset >= 1008 and pHero.m_offset < 1012 then
			SetText( uiFlag, T(2049) )
		else
			SetText( uiFlag, "" )
		end
		m_CacheHeroList[pHero.m_kind] = uiHeroObj;
	end
end

-- 武将列表清空
function GirlSelectHeroDlgListClear()
	local objs = {};
	for i = 0 ,m_uiContent.transform.childCount - 1 do
		table.insert( objs, m_uiContent.transform:GetChild(i).gameObject )
    end
	for k, v in pairs(objs) do
		local obj = v;
		m_ObjectPool:Release( "UIP_HeroHead", obj );
    end
	m_CacheHeroCache = {};
	m_CacheHeroList = {};
	m_upHeroCache = {}
end

-- 选择武将
function GirlSelectHeroDlgSelectHero( kind )
	local uiHeroObj = m_CacheHeroList[kind];
	if uiHeroObj == nil then
		return
	end
	
	local preObjs = preObj.transform:GetComponent( typeof(Reference) ).relatedGameObject;
	local preUiSelect = preObjs[4];
	SetFalse(preUiSelect);

	local objs = uiHeroObj.transform:GetComponent( typeof(Reference) ).relatedGameObject;
	local uiSelect = objs[4];
	SetTrue(uiSelect);
	preObj = uiHeroObj;
	ShowStar(kind);
end

function ShowStar(kind)
	if girlConifg.m_herokind == kind then
		InitStar(girlConifg.private_love_star);
	else
		InitStar(girlConifg.love_star);
	end
end

function InitStar(count)
	HideStar();
	for i = 0 ,count - 1 do
		local objs = m_uiStarContent.transform:GetChild(i).gameObject
		SetTrue( objs );
    end 
end

function HideStar()
	for i = 0 ,m_uiStarContent.transform.childCount - 1 do
		local objs = m_uiStarContent.transform:GetChild(i).gameObject
		SetFalse( objs );
    end
end