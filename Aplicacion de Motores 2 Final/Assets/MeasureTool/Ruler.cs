using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class Ruler : MonoBehaviour
{
    [TextArea] public string description;

    public GameObject otherObj;

    public bool show;

   // public virtual StickyNote RulerStickyNote { get; private set; }

    private void Awake()
    {
      //  RulerStickyNote = gameObject.AddComponent<StickyNote>();        
    }
    public string DistanceMeasure(GameObject asset)
    {
        if (asset)
        {
            if (GameObject.Find(asset.name))
            {
                return "Distance from "+ gameObject.name + " To " + otherObj.name +": " + Vector3.Distance(transform.position, otherObj.transform.position).ToString();                                
            }
            return "MUST BE A OBJECT IN THE SCENE";
        }
        return "ASSIGN A GAMEOBJECT IN THE SCENE TO BE MEASURE";               
    }    
}
