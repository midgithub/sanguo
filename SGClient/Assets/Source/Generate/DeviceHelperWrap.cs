﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DeviceHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("DeviceHelper");
		L.RegFunction("getCountry", getCountry);
		L.RegFunction("getLanguage", getLanguage);
		L.RegFunction("GetDeviceDesc", GetDeviceDesc);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getCountry(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = DeviceHelper.getCountry();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLanguage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = DeviceHelper.getLanguage();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeviceDesc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = DeviceHelper.GetDeviceDesc();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

