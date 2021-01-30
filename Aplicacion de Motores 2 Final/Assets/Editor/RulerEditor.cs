using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Ruler))]
public class RulerEditor : Editor
{
	public GUIStyle style;

	private void OnEnable()
	{
		//style = EditorStyles.helpBox;
		//style.normal.background = Texture2D.whiteTexture;
	}
	private void OnSceneGUI()
    {
		Ruler myRuler = (Ruler)target;
        if (myRuler.show)
        {
			if (myRuler.otherObj)
			{
				Handles.Label(GetLabelPosition(myRuler.transform.position, myRuler.otherObj.transform.position), myRuler.description);
				Handles.DrawLine(myRuler.transform.position, myRuler.otherObj.transform.position);
			}
			else
			{
				Handles.Label(myRuler.transform.position, myRuler.description, style);
			}
			myRuler.description = myRuler.DistanceMeasure(myRuler.otherObj);
		}		
	}	

	public Vector3 GetLabelPosition(Vector3 pos1, Vector3 pos2)
    {
		return  pos1 + (pos2 - pos1)/2;
    }
}
