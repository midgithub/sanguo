﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GizmoBezierLineWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GizmoBezierLine), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Refresh", Refresh);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("points", get_points, set_points);
		L.RegVar("smooth", get_smooth, set_smooth);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Refresh(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GizmoBezierLine obj = (GizmoBezierLine)ToLua.CheckObject(L, 1, typeof(GizmoBezierLine));
			obj.Refresh();
			return 0;
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
	static int get_points(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GizmoBezierLine obj = (GizmoBezierLine)o;
			UnityEngine.Vector3[] ret = obj.points;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index points on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_smooth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GizmoBezierLine obj = (GizmoBezierLine)o;
			int ret = obj.smooth;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index smooth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_points(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GizmoBezierLine obj = (GizmoBezierLine)o;
			UnityEngine.Vector3[] arg0 = ToLua.CheckObjectArray<UnityEngine.Vector3>(L, 2);
			obj.points = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index points on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_smooth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GizmoBezierLine obj = (GizmoBezierLine)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.smooth = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index smooth on a nil value" : e.Message);
		}
	}
}

