﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class eyeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(eye), typeof(System.Object));
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("New", _Createeye);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("manager", get_manager, null);
		L.RegVar("gameManager", get_gameManager, null);
		L.RegVar("luaManager", get_luaManager, null);
		L.RegVar("networkManager", get_networkManager, null);
		L.RegVar("uiManager", get_uiManager, null);
		L.RegVar("resourceManager", get_resourceManager, null);
		L.RegVar("objectPoolManager", get_objectPoolManager, null);
		L.RegVar("serverTime", get_serverTime, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createeye(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				eye obj = new eye();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: eye.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			eye.Destroy();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_manager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.manager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameManager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.gameManager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaManager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.luaManager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_networkManager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.networkManager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uiManager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.uiManager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resourceManager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.resourceManager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_objectPoolManager(IntPtr L)
	{
		try
		{
			ToLua.Push(L, eye.objectPoolManager);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_serverTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, eye.serverTime);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

