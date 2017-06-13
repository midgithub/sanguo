﻿using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Text;
using UnityEditor.ProjectWindowCallback;
using System.Text.RegularExpressions;
 
public class Test
{
    [MenuItem("Assets/Create/LuaDlg Script", false, 80)]
    public static void CreatNewLuaDlg()
    {
        ProjectWindowUtil.StartNameEditingIfProjectWindowExists( 0, ScriptableObject.CreateInstance<MyDoCreateScriptAsset>(), GetSelectedPathOrFallback() + "/New Lua.lua", null,
       "Assets/Lua/uidlg/TemplateDlg.lua");
    }

    [MenuItem( "Assets/Create/LuaMod Script", false, 80 )]
    public static void CreatNewLuaMod()
    {
        ProjectWindowUtil.StartNameEditingIfProjectWindowExists( 0, ScriptableObject.CreateInstance<MyDoCreateScriptAsset>(), GetSelectedPathOrFallback() + "/New Lua.lua", null,
       "Assets/Lua/uimod/TemplateMod.lua" );
    }
 
    public static string GetSelectedPathOrFallback()
    {
        string path = "Assets";
        foreach ( UnityEngine.Object obj in Selection.GetFiltered( typeof( UnityEngine.Object ), SelectionMode.Assets ) )
        {
            path = AssetDatabase.GetAssetPath( obj );
            if ( !string.IsNullOrEmpty( path ) && File.Exists( path ) )
            {
                path = Path.GetDirectoryName( path );
                break;
            }
        }
        return path;
    }
}    
 
 
class MyDoCreateScriptAsset : EndNameEditAction
{
 
    public override void Action(int instanceId, string pathName, string resourceFile)
    {
        UnityEngine.Object o = CreateScriptAssetFromTemplate(pathName, resourceFile);
        ProjectWindowUtil.ShowCreatedAsset(o);
    }
 
    internal static UnityEngine.Object CreateScriptAssetFromTemplate(string pathName, string resourceFile)
    {
        string fullPath = Path.GetFullPath(pathName);
        StreamReader streamReader = new StreamReader(resourceFile);
        string text = streamReader.ReadToEnd();
        streamReader.Close();
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathName);
        text = Regex.Replace(text, "#NAME#", fileNameWithoutExtension);
        bool append = false;
        StreamWriter streamWriter = new StreamWriter(fullPath, append );
        streamWriter.Write(text);
        streamWriter.Close();
        AssetDatabase.ImportAsset(pathName);
        return AssetDatabase.LoadAssetAtPath(pathName, typeof(UnityEngine.Object));
    }
 
}    