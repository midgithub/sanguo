﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UtilsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Utils), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetTime", GetTime);
		L.RegFunction("Vibrate", Vibrate);
		L.RegFunction("Encode", Encode);
		L.RegFunction("Decode", Decode);
		L.RegFunction("IsNumeric", IsNumeric);
		L.RegFunction("IsNumber", IsNumber);
		L.RegFunction("HashToMD5Hex", HashToMD5Hex);
		L.RegFunction("md5", md5);
		L.RegFunction("md5file", md5file);
		L.RegFunction("CompressFile", CompressFile);
		L.RegFunction("DecompressFile", DecompressFile);
		L.RegFunction("Compress", Compress);
		L.RegFunction("String2Array", String2Array);
		L.RegFunction("Decompress", Decompress);
		L.RegFunction("ClearChild", ClearChild);
		L.RegFunction("GetFileText", GetFileText);
		L.RegFunction("Exists", Exists);
		L.RegFunction("CreateDirectory", CreateDirectory);
		L.RegFunction("Log", Log);
		L.RegFunction("LogWarning", LogWarning);
		L.RegFunction("LogError", LogError);
		L.RegFunction("LoadAsset", LoadAsset);
		L.RegFunction("AddComponent", AddComponent);
		L.RegFunction("PushBufferToLua", PushBufferToLua);
		L.RegFunction("get_sflag", get_sflag);
		L.RegFunction("get_int_sflag", get_int_sflag);
		L.RegFunction("set_int_sflag", set_int_sflag);
		L.RegFunction("byteAndOp", byteAndOp);
		L.RegFunction("IntAndOp", IntAndOp);
		L.RegFunction("HexColor32", HexColor32);
		L.RegFunction("HexColor", HexColor);
		L.RegFunction("IsPointerOverUIObject", IsPointerOverUIObject);
		L.RegFunction("GetCharacterWidth", GetCharacterWidth);
		L.RegFunction("IsEmojiCharacter", IsEmojiCharacter);
		L.RegFunction("GetTimeFormat", GetTimeFormat);
		L.RegFunction("GetTimeFormatISO", GetTimeFormatISO);
		L.RegFunction("GetMillisecond", GetMillisecond);
		L.RegFunction("StringFormat", StringFormat);
		L.RegFunction("ScreenPointToLocalPointInRectangle", ScreenPointToLocalPointInRectangle);
		L.RegFunction("GetFiles", GetFiles);
		L.RegFunction("GetFilesNum", GetFilesNum);
		L.RegFunction("FileTimeString", FileTimeString);
		L.RegFunction("FileTimeInt", FileTimeInt);
		L.RegFunction("FileSize", FileSize);
		L.RegFunction("ChangeLayer", ChangeLayer);
		L.RegFunction("GetPreferredSize", GetPreferredSize);
		L.RegFunction("ExcuteLuaFunction", ExcuteLuaFunction);
		L.RegFunction("CreateWaveHead", CreateWaveHead);
		L.RegFunction("CreateAudioClipByPcm", CreateAudioClipByPcm);
		L.RegFunction("MaskWordInit", MaskWordInit);
		L.RegFunction("MaskWordProcess", MaskWordProcess);
		L.RegFunction("MaskWordCheck", MaskWordCheck);
		L.RegFunction("TrackOver", TrackOver);
		L.RegFunction("GotoMarket", GotoMarket);
		L.RegFunction("MemSize", MemSize);
		L.RegFunction("StringReplace", StringReplace);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("NetAvailable", get_NetAvailable, null);
		L.RegVar("IsWifi", get_IsWifi, null);
		L.RegVar("platform", get_platform, null);
		L.RegVar("isMobilePlatform", get_isMobilePlatform, null);
		L.RegVar("operatingSystem", get_operatingSystem, null);
		L.RegVar("deviceUniqueIdentifier", get_deviceUniqueIdentifier, null);
		L.RegVar("deviceModel", get_deviceModel, null);
		L.RegVar("systemLanguage", get_systemLanguage, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			long o = Utils.GetTime();
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vibrate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Utils.Vibrate();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Encode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.Encode(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Decode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.Decode(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsNumeric(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = Utils.IsNumeric(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsNumber(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = Utils.IsNumber(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HashToMD5Hex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.HashToMD5Hex(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int md5(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.md5(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int md5file(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.md5file(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompressFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			Utils.CompressFile(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecompressFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.DecompressFile(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Compress(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.Compress(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int String2Array(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string[] o = Utils.String2Array(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Decompress(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.Decompress(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			Utils.ClearChild(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.GetFileText(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exists(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = Utils.Exists(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateDirectory(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Utils.CreateDirectory(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Utils.Log(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Utils.LogWarning(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Utils.LogError(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AssetBundle arg0 = (UnityEngine.AssetBundle)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.AssetBundle));
			string arg1 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = Utils.LoadAsset(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddComponent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			UnityEngine.Component o = Utils.AddComponent(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PushBufferToLua(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			byte[] arg1 = ToLua.CheckByteBuffer(L, 2);
			Utils.PushBufferToLua(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sflag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 1);
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 2);
			byte o = Utils.get_sflag(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_int_sflag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = Utils.get_int_sflag(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_int_sflag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = Utils.set_int_sflag(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int byteAndOp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 1);
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 2);
			byte o = Utils.byteAndOp(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntAndOp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = Utils.IntAndOp(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HexColor32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Color32 o = Utils.HexColor32(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HexColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Color o = Utils.HexColor(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPointerOverUIObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = Utils.IsPointerOverUIObject(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharacterWidth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.UI.Text));
			int o = Utils.GetCharacterWidth(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsEmojiCharacter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			char arg0 = (char)LuaDLL.luaL_checknumber(L, 1);
			bool o = Utils.IsEmojiCharacter(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTimeFormat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			string o = Utils.GetTimeFormat(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTimeFormatISO(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			string o = Utils.GetTimeFormatISO(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMillisecond(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = Utils.GetMillisecond();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StringFormat(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			string arg0 = ToLua.CheckString(L, 1);
			object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
			string o = Utils.StringFormat(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenPointToLocalPointInRectangle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
			UnityEngine.Camera arg2 = (UnityEngine.Camera)ToLua.CheckUnityObject(L, 3, typeof(UnityEngine.Camera));
			UnityEngine.Vector2 o = Utils.ScreenPointToLocalPointInRectangle(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFiles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string[] o = Utils.GetFiles(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFilesNum(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			int o = Utils.GetFilesNum(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FileTimeString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.FileTimeString(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FileTimeInt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			double o = Utils.FileTimeInt(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FileSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			int o = Utils.FileSize(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeLayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			Utils.ChangeLayer(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPreferredSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = Utils.GetPreferredSize(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExcuteLuaFunction(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			string arg0 = ToLua.CheckString(L, 1);
			object arg1 = ToLua.ToVarObject(L, 2);
			object arg2 = ToLua.ToVarObject(L, 3);
			object arg3 = ToLua.ToVarObject(L, 4);
			object o = Utils.ExcuteLuaFunction(arg0, arg1, arg2, arg3);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateWaveHead(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			short arg0 = (short)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			short arg2 = (short)LuaDLL.luaL_checknumber(L, 3);
			byte[] o = Utils.CreateWaveHead(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateAudioClipByPcm(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
			UnityEngine.AudioClip o = Utils.CreateAudioClipByPcm(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MaskWordInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Utils.MaskWordInit();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MaskWordProcess(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Utils.MaskWordProcess(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MaskWordCheck(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = Utils.MaskWordCheck(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrackOver(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Utils.TrackOver();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GotoMarket(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Utils.GotoMarket();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MemSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = Utils.MemSize();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StringReplace(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string o = Utils.StringReplace(arg0, arg1, arg2);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NetAvailable(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, Utils.NetAvailable);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsWifi(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, Utils.IsWifi);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_platform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, Utils.platform);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMobilePlatform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, Utils.isMobilePlatform);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_operatingSystem(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Utils.operatingSystem);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deviceUniqueIdentifier(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Utils.deviceUniqueIdentifier);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deviceModel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Utils.deviceModel);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_systemLanguage(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, Utils.systemLanguage);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

