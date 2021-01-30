using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;


[ExecuteInEditMode]
public class LightSettingsSetter : MonoBehaviour
{
    public Light myLight;

    public LightSettings myLightSettings;

    public bool lightSettingsToScriptable;

    public bool settingsToLight;

    private void Update()
    {
        if (lightSettingsToScriptable && myLight && myLightSettings)
        {
            SettingFromLightToScriptable(myLight, myLightSettings);
            lightSettingsToScriptable = false;
        }
        else if(settingsToLight && myLight && myLightSettings)
        {
            SettingFromScriptableToLight(myLightSettings, myLight);
            settingsToLight = false;
        }
    }

    public void SettingFromLightToScriptable(Light light, LightSettings settings)
    {               
        if (light.type == UnityEngine.LightType.Spot || light.type == UnityEngine.LightType.Point)
        { 
            settings.Range = light.range; 
            settings.bakedShadowRadius = light.shadowRadius;
        }

        if (light.type == UnityEngine.LightType.Spot)
            settings.spotAngle = light.spotAngle;
                    
        settings.color = light.color;
            
        settings.mode = (UnityEngine.Experimental.GlobalIllumination.LightMode)light.renderMode;
            
        settings.intensity = light.intensity;
            
        settings.indirectMultiplier = light.bounceIntensity;
            
        settings.shadowType = light.shadows;

        if (light.type == UnityEngine.LightType.Directional)
            settings.bakedShadowAngle = light.shadowAngle;
                                                          
        settings.flare = light.flare;
            
        settings.renderMode = (RenderMode)light.renderMode;
            
        settings.cullingMask = light.cullingMask;               
    }

    public void SettingFromScriptableToLight(LightSettings settings, Light light)
    {
        if (settings.type == UnityEngine.LightType.Spot || settings.type == UnityEngine.LightType.Point)
        {
            light.range = settings.Range;
            light.shadowRadius = settings.bakedShadowRadius;
        }

        if (settings.type == UnityEngine.LightType.Spot)
            light.spotAngle = settings.spotAngle;

        light.color = settings.color;

        light.renderMode = (LightRenderMode)settings.mode;               

        light.intensity = settings.intensity;

        light.bounceIntensity = settings.indirectMultiplier;
        
        light.shadows = settings.shadowType;

        if (settings.type == UnityEngine.LightType.Directional)
            light.shadowAngle = settings.bakedShadowAngle;

        light.flare = settings.flare;
        
        light.renderMode = (LightRenderMode)settings.renderMode;
        
        light.cullingMask = settings.cullingMask;
    }
}
