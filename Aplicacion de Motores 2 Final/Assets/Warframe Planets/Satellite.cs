using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour {

    [Header("Satellite")]

    [Space(10)]
    [Header("Orbitation Variables")]
    public float rotationSpeed;        
    public Transform sun;
  
    /*  [Tooltip("Sets the normal of the orbiting")]    
    [Range(0f, 1f)]
    public float xAxis;
    [Range(0f, 1f)]
    public float yAxis;
    [Range(0f, 1f)]
    public float zAxis;*/
    

    [Tooltip("Toggle On to orbit like the moon facing the earth")]
    public bool lookAtRotation; 

    [Space(10)]
    [Header("Debuggin")]
    [SerializeField]
    private float dist;

    private void Awake()
    {
        if (transform.position.y != 0)
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        }
    }
    private void Start()
    {
        if (transform.position.y != 0)
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        }
    }
    private void Update()
    {
        
        Vector3 setRotation = new Vector3(0, 1, 0);

        transform.RotateAround(sun.position,setRotation, rotationSpeed * Time.deltaTime);
        dist = Vector3.Distance(sun.position, transform.position);
        if(lookAtRotation)
        {
            transform.LookAt(sun);            
        }

    }    
}
