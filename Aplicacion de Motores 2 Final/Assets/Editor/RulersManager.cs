using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class RulersManager : EditorWindow
{
    public Ruler[] objectsWithTheComponent;

    [MenuItem("Tools/Rulers Manager")]

    public static void ShowWindow()
    {
        GetWindow<RulersManager>("Rulers Manager");
    }

    void OnGUI()
    {
        GUILayout.Label("You have " + FindRulers().Length + " Rulers", EditorStyles.boldLabel);

        if (GUILayout.Button("Disable Rulers"))
        {
            ShowAllRulers(false);
        }
        if (GUILayout.Button("Enable Rulers"))
        {
            ShowAllRulers(true);            
        }
        if (GUILayout.Button("Delete All Rulers"))
        {
            DeleteRulers();
        }
    }

    public Ruler[] FindRulers()
    {
        return FindObjectsOfType<Ruler>();
    }

    public void ShowAllRulers(bool t)
    {
        foreach (Ruler item in FindRulers())
        {
            item.show = t;
        }
        //Selection.objects = FindRulers();        
    }    

    public void DeleteRulers()
    {
        foreach (Ruler item in FindRulers())
        {
            DestroyImmediate(item);
        }
    }
}
