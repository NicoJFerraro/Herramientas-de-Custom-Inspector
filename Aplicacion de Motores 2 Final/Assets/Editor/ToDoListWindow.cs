using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
public class ToDoListWindow : EditorWindow
{
    public ToDoList myToDoList;
    private Vector2 _scrollPosition;

    [MenuItem("Tools/To Do List")]

    public static void ShowWindow()
    {
        GetWindow<ToDoListWindow>("To Do List");       
    }
    private void OnEnable()
    {
    }
    private void OnGUI()
    {
        GUILayout.Label("Create, check and delete and delete your tasks", EditorStyles.boldLabel);

        myToDoList = FindObjectOfType<ToDoList>();
        
        EditorGUILayout.BeginVertical(GUILayout.Height(position.height - 67f));

        _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition, true, true);

        for (int i = 0; i < myToDoList.task.Count; i++)
        {            
            GUILayout.BeginHorizontal();
            myToDoList.task[i] = GUILayout.TextField(myToDoList.task[i]);                
            myToDoList.check[i] = GUILayout.Toggle(myToDoList.check[i], "");
            if (GUILayout.Button("Delete Task"))
            {
                myToDoList.task.Remove(myToDoList.task[i]);
                myToDoList.check.Remove(myToDoList.check[i]);
            }

            GUILayout.EndHorizontal();
        }

        EditorGUILayout.EndScrollView();
        EditorGUILayout.EndVertical();
        
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        if (GUILayout.Button("Add Task"))
        {
            myToDoList.task.Add(myToDoList.task.Count().ToString());
            myToDoList.check.Add(false);
        }        
    }        
}