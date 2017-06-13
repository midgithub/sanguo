﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Open", Open);
		L.RegFunction("OnOpen", OnOpen);
		L.RegFunction("IsAllUIClose", IsAllUIClose);
		L.RegFunction("OpenCount", OpenCount);
		L.RegFunction("Close", Close);
		L.RegFunction("OnClose", OnClose);
		L.RegFunction("CloseLast", CloseLast);
		L.RegFunction("CloseAll", CloseAll);
		L.RegFunction("GetUIRoot", GetUIRoot);
		L.RegFunction("GetUICamera", GetUICamera);
		L.RegFunction("GetCanvas", GetCanvas);
		L.RegFunction("GetLayer", GetLayer);
		L.RegFunction("Unload", Unload);
		L.RegFunction("Clear", Clear);
		L.RegFunction("ShowMask", ShowMask);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("UI_MAXCOUNT", 16);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Open(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = obj.Open(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnOpen(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			UISystem arg0 = (UISystem)ToLua.CheckUnityObject(L, 2, typeof(UISystem));
			obj.OnOpen(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAllUIClose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			bool o = obj.IsAllUIClose();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			int o = obj.OpenCount();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			string arg0 = ToLua.CheckString(L, 2);
			obj.Close(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnClose(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UIManager), typeof(UISystem)))
			{
				UIManager obj = (UIManager)ToLua.ToObject(L, 1);
				UISystem arg0 = (UISystem)ToLua.ToObject(L, 2);
				obj.OnClose(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UIManager), typeof(UISystem), typeof(bool)))
			{
				UIManager obj = (UIManager)ToLua.ToObject(L, 1);
				UISystem arg0 = (UISystem)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.OnClose(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIManager.OnClose");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseLast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			bool o = obj.CloseLast();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseAll(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UIManager)))
			{
				UIManager obj = (UIManager)ToLua.ToObject(L, 1);
				obj.CloseAll();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UIManager), typeof(string)))
			{
				UIManager obj = (UIManager)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.CloseAll(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIManager.CloseAll");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUIRoot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			UnityEngine.Transform o = obj.GetUIRoot();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUICamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			UnityEngine.Camera o = obj.GetUICamera();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCanvas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			UnityEngine.Canvas o = obj.GetCanvas();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Transform o = obj.GetLayer(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			UISystem arg0 = (UISystem)ToLua.CheckUnityObject(L, 2, typeof(UISystem));
			obj.Unload(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			obj.Clear();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowMask(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIManager obj = (UIManager)ToLua.CheckObject(L, 1, typeof(UIManager));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.ShowMask(arg0);
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
}

