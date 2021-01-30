using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class SatelliteSpawner : MonoBehaviour
{    
    [Header("The center/sun for the satellite")]
    [Tooltip("You need this in order to spawn something")]
    public Transform center_sun;

    //IF IT IS A PRIMITIVE     
    [Header("Spawn a primitive")]
    public PrimitiveType primitiveType = PrimitiveType.Sphere;
    //IF IT IS A PREFAB    
    [Header("Spawn a prefab(must be a GameObject)")]
    public GameObject objectToSpawn;

    //BOTH CASES    
    [Header("Presets")]
    [Tooltip("To default leave it in Vector3.One or Vector3.Zero")]
    public Vector3 scale;
    public Material material;
    
    [Header("Methods")]
    [Tooltip("Toggle this to spawn a primitive")]
    [Space(5)]
    public bool createPrimitive;
    [Tooltip("Toggle this to reset the spawner position to Vector3.Zero")]
    [Space(5)]
    public bool resetSpawnPos;
    [Tooltip("Toggle this to spawn")]
    [Space(5)]
    public bool doSpawn;        

    void Update()
    {
        if (doSpawn)
        {
            if (createPrimitive)
            {
                GameObject primitive = GameObject.CreatePrimitive(primitiveType);
                Spawn(primitive);
            }
            else if (objectToSpawn)
            {
                Instantiate(objectToSpawn);
                Spawn(objectToSpawn);
            }
            else
            {
                Debug.LogError("Assign a prefab or create a primitive");
            }
            doSpawn = false;
        }

        if (resetSpawnPos)
        {
            transform.position = Vector3.zero;
            resetSpawnPos = false;
        }
        if (transform.position.y != 0)
        {
            transform.position = new Vector3 (transform.position.x, 0f, transform.position.z);            
        }
    }

    public void Spawn(GameObject satellite)
    {
        if(!satellite.GetComponent<Satellite>())
            satellite.AddComponent<Satellite>();
        
        Satellite mySat = satellite.GetComponent<Satellite>();
        
        mySat.sun = center_sun;

        satellite.transform.position = new Vector3 (transform.position.x, 0f, transform.position.z);
        
        if (scale == Vector3.zero)        
            satellite.transform.localScale = Vector3.one;        
        else        
            satellite.transform.localScale = scale;

        if (satellite.GetComponent<Collider>())
        {
            satellite.GetComponent<Collider>().enabled = false;
        }
        
        if(material)
        satellite.GetComponent<Renderer>().material = material;

    }
}
