﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIInputFieldSubmitWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIInputFieldSubmit), typeof(UnityEngine.UI.Selectable));
		L.RegFunction("MoveTextEnd", MoveTextEnd);
		L.RegFunction("MoveTextStart", MoveTextStart);
		L.RegFunction("ScreenToLocal", ScreenToLocal);
		L.RegFunction("OnBeginDrag", OnBeginDrag);
		L.RegFunction("OnDrag", OnDrag);
		L.RegFunction("OnEndDrag", OnEndDrag);
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("ProcessEvent", ProcessEvent);
		L.RegFunction("OnUpdateSelected", OnUpdateSelected);
		L.RegFunction("Rebuild", Rebuild);
		L.RegFunction("LayoutComplete", LayoutComplete);
		L.RegFunction("GraphicUpdateComplete", GraphicUpdateComplete);
		L.RegFunction("ActivateInputField", ActivateInputField);
		L.RegFunction("OnSelect", OnSelect);
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("DeactivateInputField", DeactivateInputField);
		L.RegFunction("OnDeselect", OnDeselect);
		L.RegFunction("OnSubmit", OnSubmit);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("controlID", get_controlID, set_controlID);
		L.RegVar("uiMod", get_uiMod, set_uiMod);
		L.RegVar("shouldHideMobileInput", get_shouldHideMobileInput, set_shouldHideMobileInput);
		L.RegVar("text", get_text, set_text);
		L.RegVar("isFocused", get_isFocused, null);
		L.RegVar("caretBlinkRate", get_caretBlinkRate, set_caretBlinkRate);
		L.RegVar("textComponent", get_textComponent, set_textComponent);
		L.RegVar("placeholder", get_placeholder, set_placeholder);
		L.RegVar("selectionColor", get_selectionColor, set_selectionColor);
		L.RegVar("onEndEdit", get_onEndEdit, set_onEndEdit);
		L.RegVar("onValueChange", get_onValueChange, set_onValueChange);
		L.RegVar("onValidateInput", get_onValidateInput, set_onValidateInput);
		L.RegVar("characterLimit", get_characterLimit, set_characterLimit);
		L.RegVar("contentType", get_contentType, set_contentType);
		L.RegVar("lineType", get_lineType, set_lineType);
		L.RegVar("inputType", get_inputType, set_inputType);
		L.RegVar("keyboardType", get_keyboardType, set_keyboardType);
		L.RegVar("characterValidation", get_characterValidation, set_characterValidation);
		L.RegVar("multiLine", get_multiLine, null);
		L.RegVar("asteriskChar", get_asteriskChar, set_asteriskChar);
		L.RegVar("wasCanceled", get_wasCanceled, null);
		L.RegVar("caretPosition", get_caretPosition, set_caretPosition);
		L.RegVar("selectionAnchorPosition", get_selectionAnchorPosition, set_selectionAnchorPosition);
		L.RegVar("selectionFocusPosition", get_selectionFocusPosition, set_selectionFocusPosition);
		L.RegFunction("OnValidateInput", UIInputFieldSubmit_OnValidateInput);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveTextEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.MoveTextEnd(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveTextStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.MoveTextStart(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenToLocal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			UnityEngine.Vector2 o = obj.ScreenToLocal(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnBeginDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEndDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnEndDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProcessEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.Event arg0 = (UnityEngine.Event)ToLua.CheckObject(L, 2, typeof(UnityEngine.Event));
			obj.ProcessEvent(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdateSelected(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnUpdateSelected(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
			obj.Rebuild(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LayoutComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			obj.LayoutComplete();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GraphicUpdateComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			obj.GraphicUpdateComplete();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ActivateInputField(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			obj.ActivateInputField();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSelect(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeactivateInputField(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			obj.DeactivateInputField();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeselect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnDeselect(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSubmit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)ToLua.CheckObject(L, 1, typeof(UIInputFieldSubmit));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSubmit(arg0);
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
	static int get_controlID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int ret = obj.controlID;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index controlID on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uiMod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIMod ret = obj.uiMod;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index uiMod on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shouldHideMobileInput(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			bool ret = obj.shouldHideMobileInput;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index shouldHideMobileInput on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			string ret = obj.text;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index text on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFocused(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			bool ret = obj.isFocused;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isFocused on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_caretBlinkRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			float ret = obj.caretBlinkRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index caretBlinkRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textComponent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.UI.Text ret = obj.textComponent;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index textComponent on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_placeholder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.UI.Graphic ret = obj.placeholder;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index placeholder on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selectionColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.Color ret = obj.selectionColor;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index selectionColor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEndEdit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.SubmitEvent ret = obj.onEndEdit;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onEndEdit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.OnChangeEvent ret = obj.onValueChange;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValueChange on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValidateInput(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.OnValidateInput ret = obj.onValidateInput;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValidateInput on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_characterLimit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int ret = obj.characterLimit;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index characterLimit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.ContentType ret = obj.contentType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index contentType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lineType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.LineType ret = obj.lineType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index lineType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inputType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.InputType ret = obj.inputType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index inputType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keyboardType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.TouchScreenKeyboardType ret = obj.keyboardType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index keyboardType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_characterValidation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.CharacterValidation ret = obj.characterValidation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index characterValidation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_multiLine(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			bool ret = obj.multiLine;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index multiLine on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asteriskChar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			char ret = obj.asteriskChar;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index asteriskChar on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wasCanceled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			bool ret = obj.wasCanceled;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index wasCanceled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_caretPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int ret = obj.caretPosition;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index caretPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selectionAnchorPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int ret = obj.selectionAnchorPosition;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index selectionAnchorPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selectionFocusPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int ret = obj.selectionFocusPosition;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index selectionFocusPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_controlID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.controlID = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index controlID on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uiMod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIMod arg0 = (UIMod)ToLua.CheckUnityObject(L, 2, typeof(UIMod));
			obj.uiMod = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index uiMod on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shouldHideMobileInput(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.shouldHideMobileInput = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index shouldHideMobileInput on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.text = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index text on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_caretBlinkRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.caretBlinkRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index caretBlinkRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_textComponent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Text));
			obj.textComponent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index textComponent on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_placeholder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.UI.Graphic arg0 = (UnityEngine.UI.Graphic)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Graphic));
			obj.placeholder = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index placeholder on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selectionColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.selectionColor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index selectionColor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEndEdit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.SubmitEvent arg0 = (UIInputFieldSubmit.SubmitEvent)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.SubmitEvent));
			obj.onEndEdit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onEndEdit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.OnChangeEvent arg0 = (UIInputFieldSubmit.OnChangeEvent)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.OnChangeEvent));
			obj.onValueChange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValueChange on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValidateInput(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.OnValidateInput arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UIInputFieldSubmit.OnValidateInput)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.OnValidateInput));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UIInputFieldSubmit.OnValidateInput), func) as UIInputFieldSubmit.OnValidateInput;
			}

			obj.onValidateInput = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValidateInput on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_characterLimit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.characterLimit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index characterLimit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_contentType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.ContentType arg0 = (UIInputFieldSubmit.ContentType)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.ContentType));
			obj.contentType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index contentType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lineType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.LineType arg0 = (UIInputFieldSubmit.LineType)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.LineType));
			obj.lineType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index lineType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inputType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.InputType arg0 = (UIInputFieldSubmit.InputType)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.InputType));
			obj.inputType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index inputType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keyboardType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UnityEngine.TouchScreenKeyboardType arg0 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
			obj.keyboardType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index keyboardType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_characterValidation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			UIInputFieldSubmit.CharacterValidation arg0 = (UIInputFieldSubmit.CharacterValidation)ToLua.CheckObject(L, 2, typeof(UIInputFieldSubmit.CharacterValidation));
			obj.characterValidation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index characterValidation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asteriskChar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			char arg0 = (char)LuaDLL.luaL_checknumber(L, 2);
			obj.asteriskChar = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index asteriskChar on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_caretPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.caretPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index caretPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selectionAnchorPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.selectionAnchorPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index selectionAnchorPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selectionFocusPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIInputFieldSubmit obj = (UIInputFieldSubmit)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.selectionFocusPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index selectionFocusPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UIInputFieldSubmit_OnValidateInput(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UIInputFieldSubmit.OnValidateInput), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UIInputFieldSubmit.OnValidateInput), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

