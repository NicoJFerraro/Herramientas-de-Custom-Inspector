using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Camera Settings", menuName = "Camera Settings")]
public class CameraSettings : ScriptableObject
{
    public Camera ScriptableCamera;

    //Variables
    public CameraClearFlags clearFlags;

    public Color background;
    
    public LayerMask cullingMask;

    public bool isOrtographic;

    public float ortographicSize;

    public float perspectiveFieldOfView;

    public bool physicalCamera;

    public float clippingNearPlane;

    public float clippingFarPlane;

    public float viewportRectX, viewportRectY, viewportRectW, viewportRectH;

    public float Depth;

    public RenderingPath renderingPath;

    public RenderTexture targetTexture;

    public bool ocllusionCulling;

    public bool allowHDR;

    public bool allowMSAA;

    public bool allowDynamicResolution;

    public int targetDisplay;

}
