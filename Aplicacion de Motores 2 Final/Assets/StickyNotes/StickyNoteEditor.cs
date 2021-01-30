using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StickyNote))]
public class StickyNoteEditor : Editor
{
	private GUIStyle style;

	private void OnEnable()
	{
		style = EditorStyles.helpBox;
		style.normal.background = Texture2D.whiteTexture;
	}

	private void OnSceneGUI()
	{        
		StickyNote note = (StickyNote)target;
        if (note.show)
        {
			Handles.Label(note.transform.position, note.description, style);
		}
	}
}
