using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

[CreateAssetMenu(fileName = "New Light Settings", menuName = "Light Settings")]
public class LightSettings : ScriptableObject
{
    public Light ScriptableLight;

    //Variables//hecho si es spot

    public UnityEngine.LightType type;

    public float Range; //clampear //SI ES SPOT O POINT

    public float spotAngle; // SI ES SPOT

    public Color color;

    public LightMode mode;

    public float intensity; //clampear

    public float indirectMultiplier; //clampear

    public LightShadows shadowType;

    public float bakedShadowAngle; //SI ES DIRECTIONAL

    public float bakedShadowRadius; //clampear //SI ES SPOT O POINT

    public bool drawHalo;

    public Flare flare;

    public RenderMode renderMode;

    public LayerMask cullingMask;

    //Si es area light
    public bool shapeDisc;//o rectangle

    public float width;

    public float height;

    public bool castShadows;
    
}
