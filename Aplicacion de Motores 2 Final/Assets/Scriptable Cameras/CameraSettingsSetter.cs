using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;


[ExecuteInEditMode]
public class CameraSettingsSetter : MonoBehaviour
{
    public Camera myCamera;

    public CameraSettings myCameraSettings;

    public bool cameraSettingsToScriptable;
    public bool settingsToCamera;

    private void Update()
    {
        if (settingsToCamera && myCamera && myCameraSettings)
        {
            SettingFromScriptableToCamera(myCameraSettings, myCamera);
            settingsToCamera = false;
        }
        
        if (cameraSettingsToScriptable && myCamera && myCameraSettings)
        {
            CopySettingsFromCameraToScriptableObject(myCamera, myCameraSettings);
            cameraSettingsToScriptable = false;
        }        
    }

    public void SettingFromScriptableToCamera(CameraSettings settings, Camera camera)
    {
        camera.clearFlags = settings.clearFlags;
        
        camera.backgroundColor = settings.background;
        
        camera.cullingMask = settings.cullingMask;
        
        camera.orthographic = settings.isOrtographic;
        
        if (camera.orthographic)
            camera.orthographicSize = settings.ortographicSize;
        else
            camera.fieldOfView = settings.perspectiveFieldOfView;

        camera.usePhysicalProperties = settings.physicalCamera;
        
        camera.nearClipPlane = settings.clippingNearPlane;
        
        camera.farClipPlane = settings.clippingFarPlane;
        
        camera.rect.Set(settings.viewportRectX, settings.viewportRectY, settings.viewportRectW, settings.viewportRectH);
        
        camera.depth = settings.Depth;
        
        camera.renderingPath = settings.renderingPath;
        
        camera.targetTexture = settings.targetTexture;
        
        camera.useOcclusionCulling = settings.ocllusionCulling;
        
        camera.allowHDR = settings.allowHDR;
        
        camera.allowMSAA = settings.allowMSAA;
        
        camera.allowDynamicResolution = settings.allowDynamicResolution;
        
        camera.targetDisplay = settings.targetDisplay;
    }

    public void CopySettingsFromCameraToScriptableObject(Camera camera, CameraSettings settings)
    {
        settings.clearFlags = camera.clearFlags;

        settings.background = camera.backgroundColor;
        
        settings.cullingMask = camera.cullingMask;        
        
        settings.isOrtographic = camera.orthographic;

        if (settings.isOrtographic)
            settings.ortographicSize = camera.orthographicSize;
        else
            settings.perspectiveFieldOfView = camera.fieldOfView;

        settings.physicalCamera = camera.usePhysicalProperties;
        
        settings.clippingNearPlane = camera.nearClipPlane;
        
        settings.clippingFarPlane = camera.farClipPlane;
        
        settings.viewportRectX = camera.rect.x; settings.viewportRectY = camera.rect.y; settings.viewportRectW = camera.rect.width; settings.viewportRectH = camera.rect.height;

        settings.Depth = camera.depth ;        
        
        settings.renderingPath = camera.renderingPath;
        
        settings.targetTexture = camera.targetTexture;
        
        settings.ocllusionCulling = camera.useOcclusionCulling;

        settings.allowHDR = camera.allowHDR;

        settings.allowMSAA = camera.allowMSAA;

        settings.allowDynamicResolution = camera.allowDynamicResolution;

        settings.targetDisplay = camera.targetDisplay; 
    }
}
