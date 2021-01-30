using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;


public class StickyNotesManagerWindow : EditorWindow
{
    
    public StickyNote[] objectsWithTheComponent;
    
    [MenuItem("Tools/Sticky Notes Manager")]
    public static void ShowWindow()
    {
        GetWindow<StickyNotesManagerWindow>("Component Manager");
    }

    void OnGUI()
    {
        GUILayout.Label("You have " + FindStickyNotes().Length + " Sticky Notes", EditorStyles.boldLabel);
                
        if (GUILayout.Button("Deactivate Sticky Notes")) 
        {
            EnableStickyNotes(false);
        }
        if (GUILayout.Button("Enable Sticky Notes")) 
        {
            EnableStickyNotes(true);
        }
        if (GUILayout.Button("Delete All Sticky Notes"))
        {
            DeleteStickyNotes();
        }
    }

    public void DeleteStickyNotes()
    {
        foreach (StickyNote item in FindStickyNotes())
        {
            DestroyImmediate(item);
        }
    }

    public void EnableStickyNotes(bool t)
    {
        foreach (StickyNote item in FindStickyNotes())
        {
            item.show = t;
        }
    }    

    public StickyNote[] FindStickyNotes()
    {
        return FindObjectsOfType<StickyNote>();
    }
}
