﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DragonBones_ActionTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DragonBones.ActionType));
		L.RegVar("None", get_None, null);
		L.RegVar("Play", get_Play, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, DragonBones.ActionType.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Play(IntPtr L)
	{
		ToLua.Push(L, DragonBones.ActionType.Play);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DragonBones.ActionType o = (DragonBones.ActionType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

