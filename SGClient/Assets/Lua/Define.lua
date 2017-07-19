---------------------- UI事件 ----------------------
UI_EVENT_CLICK 			    = 0;		-- UIButton单击				无参
UI_EVENT_PRESS 			    = 1;		-- UIButton按下				0 按下，1 抬起
UI_EVENT_INPUTSUBMIT	    = 2;		-- UIInputField提交			无参
UI_EVENT_TWEENFINISH	    = 3;		-- UITween播放完毕			0 正向结束，1 逆向
UI_EVENT_SCROLLDRAG		    = 4;		-- UIScrollRect拖动			0 开始拖动，1 拖动中，2 结束拖动
UI_EVENT_SLIDERVALUECHANGE  = 5;		-- UISlider值改变			slider value值
UI_EVENT_CENTERCHILD	    = 6;		-- UIScrollRing子居中		子index
UI_EVENT_TIMECOUNTEND       = 7;        -- UITextTimeCountdown      计时结束
UI_EVENT_DRAGSENSOR         = 8;        -- UIDragSensor拖拽事件
UI_EVENT_RICHTEXTSETEND     = 9;        -- UIRcihText标记点击
UI_EVENT_RICHTEXTMASKCLICK  = 10;       -- UIRcihText标记点击
UI_EVENT_INPUTVALUECHANGED  = 11;       -- UIInputField内容修改		当前inputfield内容
UI_EVENT_TIMECOUNTCHANGED   = 12;       -- 计数修改
UI_EVENT_VOICE              = 13;       -- UIVoice
UI_EVENT_PUSHEVENT		    = 1000;		-- UI通用事件，不想定义新事件可用			    参数

-- 可升级的普通建筑
BUILDING_Main           = 1  -- 主城
BUILDING_Wall           = 2  -- 城墙
BUILDING_StoreHouse     = 3  -- 仓库
BUILDING_Tech           = 4  -- 太学院
BUILDING_Craftsman      = 5  -- 材料作坊
BUILDING_Cabinet        = 6  -- 内阁

-- 兵营
BUILDING_Infantry       		= 11  -- 步兵营
BUILDING_Cavalry        		= 12  -- 骑兵营
BUILDING_Archer         		= 13  -- 弓兵营
BUILDING_Militiaman_Infantry	= 14  -- 民兵营-步兵
BUILDING_Militiaman_Cavalry		= 15  -- 民兵营-骑兵
BUILDING_Militiaman_Archer		= 16  -- 民兵营-弓兵

-- 资源建筑
BUILDING_Silver		    =  21	-- 银币
BUILDING_Wood		    =  22	-- 木材
BUILDING_Food		    =  23	-- 食物
BUILDING_Iron		    =  24   -- 镔铁

-- 纯入口建筑
BUILDING_Smithy		    =  31	-- 铁匠铺
BUILDING_Wash		    =  32	-- 洗炼铺
BUILDING_Fangshi	    =  33	-- 坊市
BUILDING_Shop		    =  34	-- 商店
BUILDING_Hero		    =  35	-- 聚贤馆
BUILDING_Wishing	    =  36	-- 聚宝盆
BUILDING_Help		    =  37	-- 帮助

-- 功能入口
CITY_FUNCTION_SMITHY		=0	-- 铁匠铺
CITY_FUNCTION_WASH			=1	-- 洗炼铺
CITY_FUNCTION_FANGSHI		=2	-- 坊市
CITY_FUNCTION_SHOP			=3	-- 商店
CITY_FUNCTION_HERO			=4	-- 聚贤馆
CITY_FUNCTION_WISHING		=5	-- 聚宝盆
CITY_FUNCTION_NATION		=10	-- 国家
CITY_FUNCTION_WORLD			=11	-- 世界
CITY_FUNCTION_STORY			=12	-- 副本
CITY_FUNCTION_MAIL			=13	-- 邮件
CITY_FUNCTION_FRIEND		=14	-- 好友
CITY_FUNCTION_NATIONEQUIP	=15	-- 国器
CITY_FUNCTION_RANK			=16	-- 排行榜
CITY_FUNCTION_AUTOBUILD		=17	-- 自动建造
CITY_FUNCTION_CHAT			=18	-- 聊天
CITY_FUNCTION_WARKEREX		=19	-- 商业建造队

BuildingPrefab={
[BUILDING_Main] = { prefab = "BUILDING_Main", land="BuildingLand0" },
[BUILDING_Wall] = { prefab = "BUILDING_Wall", land="BuildingLand1" },
[BUILDING_StoreHouse] = { prefab = "BUILDING_StoreHouse", land="BuildingLand2" },
[BUILDING_Tech] = { prefab = "BUILDING_Tech", land="BuildingLand3" },
[BUILDING_Craftsman] = { prefab = "BUILDING_Craftsman", land="BuildingLand4" },
[BUILDING_Cabinet] = { prefab = "BUILDING_Cabinet", land="BuildingLand5" },
[BUILDING_Infantry] = { prefab = "BUILDING_Infantry", land="BuildingLand6" },
[BUILDING_Cavalry] = { prefab = "BUILDING_Cavalry", land="BuildingLand7" },
[BUILDING_Archer] = { prefab = "BUILDING_Archer", land="BuildingLand8" },
[BUILDING_Militiaman_Infantry] = { prefab = "BUILDING_Militiaman_Infantry", land="BuildingLand9" },
[BUILDING_Militiaman_Cavalry] = { prefab = "BUILDING_Militiaman_Cavalry", land="BuildingLand9" },
[BUILDING_Militiaman_Archer] = { prefab = "BUILDING_Militiaman_Archer", land="BuildingLand9" },
[BUILDING_Silver] = { prefab = "BUILDING_Silver", land="ResLand" },
[BUILDING_Wood] = { prefab = "BUILDING_Wood", land="ResLand" },
[BUILDING_Food] = { prefab = "BUILDING_Food", land="ResLand" },
[BUILDING_Iron] = { prefab = "BUILDING_Iron", land="ResLand" },
[BUILDING_Smithy] = { prefab = "BUILDING_Smithy", land="BuildingLand12" },
[BUILDING_Wash] = { prefab = "BUILDING_Wash", land="BuildingLand13" },
[BUILDING_Fangshi] = { prefab = "BUILDING_Fangshi", land="BuildingLand14" },
[BUILDING_Shop] = { prefab = "BUILDING_Shop", land="BuildingLand15" },
[BUILDING_Hero] = { prefab = "BUILDING_Hero", land="BuildingLand16" },
[BUILDING_Wishing] = { prefab = "BUILDING_Wishing", land="BuildingLand17" },
[BUILDING_Help] = { prefab = "BUILDING_Help", land="BuildingLand18" },
} 
--[[
	if kind == BUILDING_Main then
	elseif kind == BUILDING_Wall then
	elseif kind == BUILDING_StoreHouse then
	elseif kind == BUILDING_Tech then
	elseif kind == BUILDING_Craftsman then
	elseif kind == BUILDING_Cabinet then
	elseif kind == BUILDING_Infantry then
	elseif kind == BUILDING_Cavalry then
	elseif kind == BUILDING_Archer then
	elseif kind == BUILDING_Militiaman_Infantry then
	elseif kind == BUILDING_Militiaman_Cavalry then
	elseif kind == BUILDING_Militiaman_Archer then
	elseif kind == BUILDING_Silver then
	elseif kind == BUILDING_Wood then
	elseif kind == BUILDING_Food then
	elseif kind == BUILDING_Iron then
	elseif kind == BUILDING_Smithy then
	elseif kind == BUILDING_Wash then
	elseif kind == BUILDING_Fangshi then
	elseif kind == BUILDING_Shop then
	elseif kind == BUILDING_Hero then
	elseif kind == BUILDING_Wishing then
	elseif kind == BUILDING_Help then
	end
--]]
-- 途径
PATH_SYSTEM						=	1	-- 系统
PATH_GM							=	2	-- GM
PATH_PAY						=	3	-- 充值
PATH_ITEMUSE					=	4	-- 道具使用
PATH_TOKENITEMUSE				=	5	-- 钻石直接使用
PATH_SELL						=	6	-- 售卖丢弃
PATH_BUILDING_UPGRADE			=	7	-- 建筑

-- 文字表
-- 获取本地化文字
function GetLocalizeText( id )
    if id == nil then
        return "";
    end
	return Localization.text( id );
end
function T( nameid )
    return GetLocalizeText( nameid );
end
function zh( text )
    return text;
end

function F( nameid, ... )
	return Utils.StringFormat( Localization.text( nameid ), ... );
end

function FQUEST( nameid, ... )
	return Utils.StringFormat( Localization.text_quest( nameid ), ... );
end

function Hex2Color( hex )
	return Utils.HexColor( hex )
end

function Hex2Color32( hex )
	return Utils.HexColor32( hex )
end

-- 写gamelog
function gamelog( msg )
	LogUtil.GetInstance():WriteGame( msg );
end

-- 写netlog
function netlog( msg )
	LogUtil.GetInstance():WriteNet( msg );
end

-- 延时执行
function Invoke(func, delay, param, name)
    if param == nil then
        param = 0;
    end
    if name == nil then
        name = "";
    end
    eye.gameManager.delayExecute = func;
    eye.gameManager:GameInvoke(delay, param, name);
end

-- 停止延时执行
function InvokeStop(name)
    eye.gameManager:GameInvoke_Stop(name);
end

-- 获取国家名称
function Nation( nation )
	return T(nation+100);
end

function NationEx( nation )
	return T(nation+110);
end

-- 获取建筑名称
function BuildingName( kind, offset )
	if kind >= BUILDING_Silver and kind <= BUILDING_Iron and offset ~= nil then
		return F( 99, offset+1, T( kind ) )
	else
		return T(kind);
	end
end

-- 获取建筑名称带等级
function BuildingNameLv( kind, offset, level )
	if kind >= BUILDING_Silver and kind <= BUILDING_Iron and offset ~= nil then
		return "Lv."..level.." "..F( 99, offset+1, T( kind ) )
	else
		return "Lv."..level.." "..T(kind);
	end
end

-- 获取英雄名称
function HeroName( kind )
	return T(kind+1000);
end

-- 获取英雄名称带等级
function HeroNameLv( kind, level )
	return "Lv."..level.." "..T(kind+1000);
end

-- 英雄状态文字
function HeroState( state )
	if state == 0 then
		return T(141);
	elseif state == 1 then
		return T(142);
	end
end

-- 兵种名称
function CorpsName( corps )
	return T(134+corps);
end

-- 获取装备名称
function EquipName( kind )
	return T(kind+2000);
end

-- 获取任务名称
function TechName( kind )
	return T(kind+3000);
end

-- 清空所有子节点
function clearChild( object )
	--for i = 0 ,object.transform.childCount - 1 do
       -- GameObject.Destroy( object.transform:GetChild(i).gameObject );
    --end
	Utils.ClearChild( object.transform );
end


-- 添加节点
function addChild( object, prefab )
	local obj = GameObject.Instantiate( prefab );
	obj.transform:SetParent( object.transform );
	obj.transform.localPosition = Vector3.zero;
	obj.transform.localScale = Vector3.one;
	obj.gameObject:SetActive( true );
	return obj;
end

-- 添加节点
function addObj( object, prefab )
	local obj = GameObject.Instantiate( prefab );
	obj.transform:SetParent( object.transform );
	obj.transform.position = object.transform.position;
	obj.transform.localScale = Vector3.one;
	return obj;
end

function SetParent( obj, parent )
	obj.transform:SetParent( parent.transform );
	obj.transform.localPosition = Vector3.zero;
	obj.transform.localScale = Vector3.one;
	obj.gameObject:SetActive( true )
end

function SetImage( transform, sprite )
	transform:GetComponent( typeof(Image) ).sprite = sprite;
end

function SetText( transform, text, color )
	local uiComponent = transform:GetComponent( typeof(UIText) );
	uiComponent.text = text;
	if color ~= nil then
		uiComponent.color = color;
	end
end

function SetLevel( transform, level, color )
	SetText( transform, "Lv."..level, color )
end

function SetTextColor( transform, color )
	transform:GetComponent( typeof(UIText) ).color = color;
end

function SetRichText( transform, text )
	transform:GetComponent( typeof(YlyRichText) ).text = text;
end

function SetControlID( transform, controlID )
	transform:GetComponent( typeof(UIButton) ).controlID = controlID;
end

function SetTimer( transform, sec, needsec, controlID, formatText )
	local timer = transform:GetComponent( typeof(UITextTimeCountdown) )
    timer:SetTime( needsec, needsec-sec );
	if sec == 0 and needsec == 0 then
		timer:Stop()
	end
	if controlID ~= nil then
		timer.controlID = controlID;
	end
	if formatText ~= nil then
		timer.formatText = formatText;
	end
end

function SetProgress( transform, value )
	transform:GetComponent( typeof(UIProgress) ):SetValue(value);
end

function SetSlider( transform, value )
	transform:GetComponent( typeof(UISlider) ).value = value;
end

function SetTrue( transform )
	transform.gameObject:SetActive( true )
end

function SetFalse( transform )
	transform.gameObject:SetActive( false )
end

function SetShow( transform, active )
	transform.gameObject:SetActive( active )
end

function IsActive( transform )
	return transform.gameObject.activeSelf
end