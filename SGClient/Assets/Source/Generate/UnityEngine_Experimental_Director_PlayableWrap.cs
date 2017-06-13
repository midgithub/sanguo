﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Experimental_Director_PlayableWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Experimental.Director.Playable), typeof(System.Object));
		L.RegFunction("IsValid", IsValid);
		L.RegFunction("New", _CreateUnityEngine_Experimental_Director_Playable);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("handle", get_handle, set_handle);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Experimental_Director_Playable(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Experimental.Director.Playable obj = new UnityEngine.Experimental.Director.Playable();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Experimental.Director.Playable.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsValid(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Experimental.Director.Playable obj = (UnityEngine.Experimental.Director.Playable)ToLua.CheckObject(L, 1, typeof(UnityEngine.Experimental.Director.Playable));
			bool o = obj.IsValid();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_handle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Experimental.Director.Playable obj = (UnityEngine.Experimental.Director.Playable)o;
			UnityEngine.Experimental.Director.PlayableHandle ret = obj.handle;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index handle on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_handle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Experimental.Director.Playable obj = (UnityEngine.Experimental.Director.Playable)o;
			UnityEngine.Experimental.Director.PlayableHandle arg0 = (UnityEngine.Experimental.Director.PlayableHandle)ToLua.CheckObject(L, 2, typeof(UnityEngine.Experimental.Director.PlayableHandle));
			obj.handle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index handle on a nil value" : e.Message);
		}
	}
}

