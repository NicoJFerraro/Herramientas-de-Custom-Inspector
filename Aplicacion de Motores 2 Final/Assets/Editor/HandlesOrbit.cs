using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Satellite))]
public class HandlesOrbit : Editor
{
    Satellite _satellite;    

    void OnEnable()
    {
        _satellite = (Satellite)target;

    }

    void OnSceneGUI()
    {

        DrawGizmos();

    }

    void DrawGizmos()
    {
        // Handles.DrawWireDisc(_satellite.sun.transform.position, _satellite.transform.position, _satellite.handleDist);
        //Handles.DrawWireDisc(_satellite.sun.transform.position, _satellite.transform.position, _satellite.handleDist);
        //Handles.CircleHandleCap(0,_satellite.transform.position,_satellite.sun.transform.rotation, _satellite.handleDist,EventType.Repaint);
        //Handles.CircleHandleCap(0,_satellite.sun.transform.position,_satellite.transform.rotation, _satellite.handleDist,EventType.Repaint);
       
       
        Handles.color = Color.white;                
        Handles.DrawWireDisc(_satellite.sun.transform.position, new Vector3(0, 1, 0), Vector3.Distance(_satellite.transform.position, _satellite.sun.transform.position));
        Handles.color = Color.magenta;
        Handles.DrawLine(_satellite.sun.transform.position, _satellite.transform.position);        
        //Handles.CircleHandleCap(0, _satellite.r, _satellite.transform.rotation, _satellite.handleDist, EventType.Repaint);
    }

}
 

