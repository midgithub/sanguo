﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DragonBones_BaseObjectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DragonBones.BaseObject), typeof(System.Object));
		L.RegFunction("SetMaxCount", SetMaxCount);
		L.RegFunction("ClearPool", ClearPool);
		L.RegFunction("ReturnToPool", ReturnToPool);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("hashCode", get_hashCode, set_hashCode);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaxCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 1, typeof(System.Type));
			uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
			DragonBones.BaseObject.SetMaxCount(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 1, typeof(System.Type));
			DragonBones.BaseObject.ClearPool(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReturnToPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DragonBones.BaseObject obj = (DragonBones.BaseObject)ToLua.CheckObject(L, 1, typeof(DragonBones.BaseObject));
			obj.ReturnToPool();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hashCode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.BaseObject obj = (DragonBones.BaseObject)o;
			uint ret = obj.hashCode;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hashCode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hashCode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.BaseObject obj = (DragonBones.BaseObject)o;
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.hashCode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hashCode on a nil value" : e.Message);
		}
	}
}

