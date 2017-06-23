--client_structrecv_auto.lua

function struct_NetS_Login_recv( buffer )
	local recvValue = {};
	recvValue.m_result = buffer:ReadInt();
	recvValue.m_username_length = buffer:ReadShort();
	recvValue.m_username = buffer:ReadStringWithLen( recvValue.m_username_length );
	recvValue.m_token_length = buffer:ReadShort();
	recvValue.m_token = buffer:ReadStringWithLen( recvValue.m_token_length );
	recvValue.m_usertype = buffer:ReadShort();
	return recvValue;
end

function struct_ListInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_actorid = buffer:ReadInt();
	recvValue.m_name = buffer:ReadStringWithLen( 22 );
	recvValue.m_nation = buffer:ReadSByte();
	recvValue.m_level = buffer:ReadShort();
	recvValue.m_offset = buffer:ReadSByte();
	recvValue.m_lockstat = buffer:ReadSByte();
	recvValue.m_delete_stoptime = buffer:ReadInt();
	recvValue.m_lock_endtime = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_List_recv( buffer )
	local recvValue = {};
	recvValue.m_actor_num = buffer:ReadSByte();
	recvValue.m_listinfo = {};
	for tmpi=1,recvValue.m_actor_num,1 do
		local tmpValue={};
		tmpValue = struct_ListInfo_recv( buffer );
		table.insert( recvValue.m_listinfo, tmpValue );
	end
	return recvValue;
end

function struct_NetS_Create_recv( buffer )
	local recvValue = {};
	recvValue.m_result = buffer:ReadSByte();
	recvValue.m_actorid = buffer:ReadInt();
	recvValue.m_createtime = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_EnterInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_actorid = buffer:ReadInt();
	recvValue.m_data_int = buffer:ReadInt();
	recvValue.m_data_short = buffer:ReadShort();
	recvValue.m_data_char = buffer:ReadSByte();
	recvValue.m_serverid = buffer:ReadShort();
	recvValue.m_servertime = buffer:ReadInt();
	recvValue.m_createtime = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_Delete_recv( buffer )
	local recvValue = {};
	recvValue.m_result = buffer:ReadInt();
	recvValue.m_actorid = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_Heart_recv( buffer )
	local recvValue = {};
	recvValue.m_value={};
	for tmpi=1,2,1 do
		recvValue.m_value[tmpi] = buffer:ReadInt();
	end
	return recvValue;
end

function struct_NetS_Notify_recv( buffer )
	local recvValue = {};
	recvValue.m_msgid = buffer:ReadShort();
	recvValue.m_valuenum = buffer:ReadShort();
	recvValue.m_value={};
	for tmpi=1,recvValue.m_valuenum,1 do
		recvValue.m_value[tmpi] = buffer:ReadInt();
	end
	recvValue.m_msg_length = buffer:ReadShort();
	recvValue.m_msg = buffer:ReadStringWithLen( recvValue.m_msg_length );
	return recvValue;
end

function struct_NetS_Building_recv( buffer )
	local recvValue = {};
	recvValue.m_kind = buffer:ReadSByte();
	recvValue.m_offset = buffer:ReadSByte();
	recvValue.m_level = buffer:ReadSByte();
	recvValue.m_sec = buffer:ReadInt();
	recvValue.m_quick = buffer:ReadSByte();
	return recvValue;
end

function struct_NetS_BuildingBarracks_recv( buffer )
	local recvValue = {};
	recvValue.m_kind = buffer:ReadSByte();
	recvValue.m_offset = buffer:ReadSByte();
	recvValue.m_level = buffer:ReadSByte();
	recvValue.m_sec = buffer:ReadInt();
	recvValue.m_quick = buffer:ReadSByte();
	return recvValue;
end

function struct_NetS_BuildingRes_recv( buffer )
	local recvValue = {};
	recvValue.m_kind = buffer:ReadSByte();
	recvValue.m_offset = buffer:ReadSByte();
	recvValue.m_level = buffer:ReadSByte();
	return recvValue;
end

function struct_NetS_BuildingList_recv( buffer )
	local recvValue = {};
	recvValue.m_building_count = buffer:ReadShort();
	recvValue.m_building = {};
	for tmpi=1,recvValue.m_building_count,1 do
		local tmpValue={};
		tmpValue = struct_NetS_Building_recv( buffer );
		table.insert( recvValue.m_building, tmpValue );
	end
	recvValue.m_barracks_count = buffer:ReadShort();
	recvValue.m_barracks = {};
	for tmpi=1,recvValue.m_barracks_count,1 do
		local tmpValue={};
		tmpValue = struct_NetS_BuildingBarracks_recv( buffer );
		table.insert( recvValue.m_barracks, tmpValue );
	end
	recvValue.m_res_count = buffer:ReadShort();
	recvValue.m_res = {};
	for tmpi=1,recvValue.m_res_count,1 do
		local tmpValue={};
		tmpValue = struct_NetS_BuildingRes_recv( buffer );
		table.insert( recvValue.m_res, tmpValue );
	end
	recvValue.m_levynum = buffer:ReadSByte();
	recvValue.m_worker_kind = buffer:ReadSByte();
	recvValue.m_worker_offset = buffer:ReadSByte();
	recvValue.m_worker_op = buffer:ReadSByte();
	recvValue.m_worker_sec = buffer:ReadInt();
	recvValue.m_worker_kind_ex = buffer:ReadSByte();
	recvValue.m_worker_offset_ex = buffer:ReadSByte();
	recvValue.m_worker_op_ex = buffer:ReadSByte();
	recvValue.m_worker_sec_ex = buffer:ReadInt();
	recvValue.m_worker_expire_ex = buffer:ReadInt();
	recvValue.m_function = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_ActorInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_actorid = buffer:ReadInt();
	recvValue.m_name = buffer:ReadStringWithLen( 22 );
	recvValue.m_nation = buffer:ReadSByte();
	recvValue.m_shape = buffer:ReadSByte();
	recvValue.m_level = buffer:ReadShort();
	recvValue.m_exp = buffer:ReadInt();
	recvValue.m_exp_max = buffer:ReadInt();
	recvValue.m_token = buffer:ReadInt();
	recvValue.m_viplevel = buffer:ReadSByte();
	recvValue.m_vipexp = buffer:ReadInt();
	recvValue.m_vipexp_max = buffer:ReadInt();
	recvValue.m_body = buffer:ReadShort();
	recvValue.m_place = buffer:ReadSByte();
	recvValue.m_official = buffer:ReadSByte();
	recvValue.m_zone = buffer:ReadShort();
	recvValue.m_battlepower = buffer:ReadInt();
	recvValue.m_silver = buffer:ReadShort();
	recvValue.m_wood = buffer:ReadShort();
	recvValue.m_food = buffer:ReadShort();
	recvValue.m_iron = buffer:ReadShort();
	recvValue.m_infantry_num = buffer:ReadInt();
	recvValue.m_cavalry_num = buffer:ReadInt();
	recvValue.m_archer_num = buffer:ReadInt();
	recvValue.m_mokilllv = buffer:ReadShort();
	recvValue.m_sflag = buffer:ReadInt();
	return recvValue;
end

function struct_Corrdinate_recv( buffer )
	local recvValue = {};
	recvValue.m_posx = buffer:ReadShort();
	recvValue.m_posy = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_ItemUse_recv( buffer )
	local recvValue = {};
	recvValue.m_itemoffset = buffer:ReadShort();
	recvValue.m_usenum = buffer:ReadShort();
	recvValue.m_effres = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_ItemPut_recv( buffer )
	local recvValue = {};
	recvValue.m_res_offset = buffer:ReadShort();
	recvValue.m_res_num = buffer:ReadShort();
	recvValue.m_target_offset = buffer:ReadShort();
	recvValue.m_target_num = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_ItemSettle_recv( buffer )
	local recvValue = {};
	recvValue.m_itemnum = buffer:ReadShort();
	recvValue.m_itemoffset={};
	for tmpi=1,recvValue.m_itemnum,1 do
		recvValue.m_itemoffset[tmpi] = buffer:ReadShort();
	end
	return recvValue;
end

function struct_NetS_LostItem_recv( buffer )
	local recvValue = {};
	recvValue.m_itemoffset = buffer:ReadShort();
	recvValue.m_itemnum = buffer:ReadShort();
	recvValue.m_targetid = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_GetItem_recv( buffer )
	local recvValue = {};
	recvValue.m_itemoffset = buffer:ReadShort();
	recvValue.m_kind = buffer:ReadShort();
	recvValue.m_type = buffer:ReadShort();
	recvValue.m_color = buffer:ReadSByte();
	recvValue.m_num = buffer:ReadShort();
	recvValue.m_targetid = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	recvValue.m_situation = buffer:ReadByte();
	return recvValue;
end

function struct_ItemSmpInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_offset = buffer:ReadShort();
	recvValue.m_kind = buffer:ReadShort();
	recvValue.m_num = buffer:ReadShort();
	recvValue.m_situation = buffer:ReadByte();
	recvValue.m_color_level = buffer:ReadSByte();
	return recvValue;
end

function struct_NetS_ItemList_recv( buffer )
	local recvValue = {};
	recvValue.m_itemext = buffer:ReadSByte();
	recvValue.m_kindnum = buffer:ReadShort();
	recvValue.m_item = {};
	for tmpi=1,recvValue.m_kindnum,1 do
		local tmpValue={};
		tmpValue = struct_ItemSmpInfo_recv( buffer );
		table.insert( recvValue.m_item, tmpValue );
	end
	return recvValue;
end

function struct_ItemAttr_recv( buffer )
	local recvValue = {};
	recvValue.m_type = buffer:ReadShort();
	recvValue.m_ability = buffer:ReadShort();
	recvValue.m_value = buffer:ReadInt();
	recvValue.m_addvalue = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_ItemInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_itemoffset = buffer:ReadShort();
	recvValue.m_itemkind = buffer:ReadShort();
	recvValue.m_type = buffer:ReadShort();
	recvValue.m_level = buffer:ReadShort();
	recvValue.m_color_level = buffer:ReadSByte();
	recvValue.m_price = buffer:ReadInt();
	recvValue.m_attr_num = buffer:ReadShort();
	recvValue.m_attr = {};
	for tmpi=1,recvValue.m_attr_num,1 do
		local tmpValue={};
		tmpValue = struct_ItemAttr_recv( buffer );
		table.insert( recvValue.m_attr, tmpValue );
	end
	return recvValue;
end

function struct_WalkPath_recv( buffer )
	local recvValue = {};
	recvValue.m_pathx={};
	for tmpi=1,100,1 do
		recvValue.m_pathx[tmpi] = buffer:ReadShort();
	end
	recvValue.m_pathy={};
	for tmpi=1,100,1 do
		recvValue.m_pathy[tmpi] = buffer:ReadShort();
	end
	recvValue.m_len = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_AddMapUnit_recv( buffer )
	local recvValue = {};
	recvValue.m_type = buffer:ReadSByte();
	recvValue.m_state = buffer:ReadSByte();
	recvValue.m_posx = buffer:ReadShort();
	recvValue.m_unit_index = buffer:ReadInt();
	recvValue.m_posy = buffer:ReadShort();
	recvValue.m_namelen = buffer:ReadSByte();
	recvValue.m_name = buffer:ReadStringWithLen( recvValue.m_namelen );
	recvValue.m_char_value_count = buffer:ReadSByte();
	recvValue.m_char_value={};
	for tmpi=1,recvValue.m_char_value_count,1 do
		recvValue.m_char_value[tmpi] = buffer:ReadSByte();
	end
	recvValue.m_short_value_count = buffer:ReadSByte();
	recvValue.m_short_value={};
	for tmpi=1,recvValue.m_short_value_count,1 do
		recvValue.m_short_value[tmpi] = buffer:ReadShort();
	end
	recvValue.m_int_value_count = buffer:ReadSByte();
	recvValue.m_int_value={};
	for tmpi=1,recvValue.m_int_value_count,1 do
		recvValue.m_int_value[tmpi] = buffer:ReadInt();
	end
	recvValue.m_prefixlen = buffer:ReadSByte();
	recvValue.m_prefix = buffer:ReadStringWithLen( recvValue.m_prefixlen );
	return recvValue;
end

function struct_NetS_DelMapUnit_recv( buffer )
	local recvValue = {};
	recvValue.m_unit_index = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_WorldMapInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_map_width = buffer:ReadShort();
	recvValue.m_map_height = buffer:ReadShort();
	recvValue.m_area_width = buffer:ReadSByte();
	recvValue.m_area_height = buffer:ReadSByte();
	recvValue.m_map_area_xnum = buffer:ReadShort();
	recvValue.m_map_area_ynum = buffer:ReadShort();
	recvValue.m_my_city_posx = buffer:ReadShort();
	recvValue.m_my_city_posy = buffer:ReadShort();
	recvValue.m_my_city_unit_index = buffer:ReadInt();
	recvValue.m_citystate = buffer:ReadSByte();
	recvValue.m_target_posx = buffer:ReadShort();
	recvValue.m_target_posy = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_MapUnitCorrdinate_recv( buffer )
	local recvValue = {};
	recvValue.m_unit_index = buffer:ReadInt();
	recvValue.m_posx = buffer:ReadShort();
	recvValue.m_posy = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_AddMarchRoute_recv( buffer )
	local recvValue = {};
	recvValue.m_from_type = buffer:ReadSByte();
	recvValue.m_from_posx = buffer:ReadShort();
	recvValue.m_from_posy = buffer:ReadShort();
	recvValue.m_to_type = buffer:ReadSByte();
	recvValue.m_to_posx = buffer:ReadShort();
	recvValue.m_to_posy = buffer:ReadShort();
	recvValue.m_state = buffer:ReadSByte();
	recvValue.m_from_actorid = buffer:ReadInt();
	recvValue.m_from_clubid = buffer:ReadInt();
	recvValue.m_to_actorid = buffer:ReadInt();
	recvValue.m_to_clubid = buffer:ReadInt();
	recvValue.m_army_index = buffer:ReadInt();
	recvValue.m_action = buffer:ReadSByte();
	return recvValue;
end

function struct_NetS_DelMarchRoute_recv( buffer )
	local recvValue = {};
	recvValue.m_army_index = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_UpdateMapUnit_recv( buffer )
	local recvValue = {};
	recvValue.m_info = struct_NetS_AddMapUnit_recv( buffer );
	return recvValue;
end

function struct_NetS_AwardInfo_recv( buffer )
	local recvValue = {};
	recvValue.m_kind = buffer:ReadInt();
	recvValue.m_num = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_AwardInfoList_recv( buffer )
	local recvValue = {};
	recvValue.m_count = buffer:ReadShort();
	recvValue.m_list = {};
	for tmpi=1,recvValue.m_count,1 do
		local tmpValue={};
		tmpValue = struct_NetS_AwardInfo_recv( buffer );
		table.insert( recvValue.m_list, tmpValue );
	end
	recvValue.m_callback_code = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Experience_recv( buffer )
	local recvValue = {};
	recvValue.m_addexp = buffer:ReadInt();
	recvValue.m_curexp = buffer:ReadInt();
	recvValue.m_isup = buffer:ReadSByte();
	recvValue.m_path = buffer:ReadShort();
	recvValue.m_level = buffer:ReadShort();
	recvValue.m_expmax = buffer:ReadInt();
	return recvValue;
end

function struct_NetS_Body_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadShort();
	recvValue.m_add = buffer:ReadShort();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Levy_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadShort();
	recvValue.m_add = buffer:ReadShort();
	recvValue.m_max = buffer:ReadShort();
	recvValue.m_sec = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Silver_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Wood_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Food_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Iron_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_People_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Prestige_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Friendship_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Vip_recv( buffer )
	local recvValue = {};
	recvValue.m_addexp = buffer:ReadInt();
	recvValue.m_curexp = buffer:ReadInt();
	recvValue.m_expmax = buffer:ReadInt();
	recvValue.m_isup = buffer:ReadSByte();
	recvValue.m_level = buffer:ReadSByte();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

function struct_NetS_Token_recv( buffer )
	local recvValue = {};
	recvValue.m_total = buffer:ReadInt();
	recvValue.m_add = buffer:ReadInt();
	recvValue.m_path = buffer:ReadShort();
	return recvValue;
end

