﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DragonBones_TransformWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DragonBones.Transform), typeof(System.Object));
		L.RegFunction("NormalizeRadian", NormalizeRadian);
		L.RegFunction("ToString", ToString);
		L.RegFunction("CopyFrom", CopyFrom);
		L.RegFunction("Identity", Identity);
		L.RegFunction("Add", Add);
		L.RegFunction("Minus", Minus);
		L.RegFunction("FromMatrix", FromMatrix);
		L.RegFunction("ToMatrix", ToMatrix);
		L.RegFunction("New", _CreateDragonBones_Transform);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("x", get_x, set_x);
		L.RegVar("y", get_y, set_y);
		L.RegVar("skewX", get_skewX, set_skewX);
		L.RegVar("skewY", get_skewY, set_skewY);
		L.RegVar("scaleX", get_scaleX, set_scaleX);
		L.RegVar("scaleY", get_scaleY, set_scaleY);
		L.RegVar("rotation", get_rotation, set_rotation);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDragonBones_Transform(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				DragonBones.Transform obj = new DragonBones.Transform();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: DragonBones.Transform.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NormalizeRadian(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			float o = DragonBones.Transform.NormalizeRadian(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyFrom(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			DragonBones.Transform arg0 = (DragonBones.Transform)ToLua.CheckObject(L, 2, typeof(DragonBones.Transform));
			DragonBones.Transform o = obj.CopyFrom(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Identity(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			DragonBones.Transform o = obj.Identity();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			DragonBones.Transform arg0 = (DragonBones.Transform)ToLua.CheckObject(L, 2, typeof(DragonBones.Transform));
			DragonBones.Transform o = obj.Add(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Minus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			DragonBones.Transform arg0 = (DragonBones.Transform)ToLua.CheckObject(L, 2, typeof(DragonBones.Transform));
			DragonBones.Transform o = obj.Minus(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FromMatrix(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			DragonBones.Matrix arg0 = (DragonBones.Matrix)ToLua.CheckObject(L, 2, typeof(DragonBones.Matrix));
			DragonBones.Transform o = obj.FromMatrix(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToMatrix(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DragonBones.Transform obj = (DragonBones.Transform)ToLua.CheckObject(L, 1, typeof(DragonBones.Transform));
			DragonBones.Matrix arg0 = (DragonBones.Matrix)ToLua.CheckObject(L, 2, typeof(DragonBones.Matrix));
			DragonBones.Transform o = obj.ToMatrix(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.x;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index x on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.y;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skewX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.skewX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index skewX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skewY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.skewY;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index skewY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scaleX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.scaleX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scaleX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scaleY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.scaleY;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scaleY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float ret = obj.rotation;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rotation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.x = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index x on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.y = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skewX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.skewX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index skewX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skewY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.skewY = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index skewY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scaleX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.scaleX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scaleX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scaleY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.scaleY = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scaleY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DragonBones.Transform obj = (DragonBones.Transform)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.rotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rotation on a nil value" : e.Message);
		}
	}
}

