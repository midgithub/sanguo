﻿using UnityEngine;
using UnityEditor;
using UnityEditor.UI;
using System.Collections;

[CustomEditor( typeof( UIMod ) )]
public class UIModEditor : Editor
{
    UIMod uimod;
    public override void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        uimod = target as UIMod;
        if ( GUILayout.Button( "自动输出Lua变量" ) )
        {
            string str = string.Empty;
            str = "--------------------------------------------------------------\n";
            foreach ( GameObject obj in uimod.relatedGameObject )
            {
                string localstr = string.Empty;
                localstr = string.Format( "local m_ui{0} = nil; --{1}\n", obj.name, obj.GetType() );
                str += localstr;
            }
            Debug.LogError( str );

            int index = 0;
            str = string.Empty;
            foreach ( GameObject obj in uimod.relatedGameObject )
            {
                string localstr = string.Empty;
                localstr = string.Format( "m_ui{0} = objs[{1}];\n", obj.name, index );
                str += localstr;
                index += 1;
            }
            Debug.LogError( str );
        }
    }
}
