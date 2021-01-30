using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AudioSourceSettingsSetter : MonoBehaviour
{
    public AudioSource myAudioSource;

    public AudioSourceSettings myAudioSettings;

    public bool audioSourceToScriptable;

    public bool scriptableToAudioSource;

    private void Update()
    {
        if (audioSourceToScriptable && myAudioSettings && myAudioSource)
        {
            SettingFromAudioSourceToAudioSourceSettings(myAudioSource, myAudioSettings);

            audioSourceToScriptable = false;
        }

        if (scriptableToAudioSource)
        {
            SettingFromScriptableToAudioSource(myAudioSettings, myAudioSource);

            scriptableToAudioSource = false;
        }        
    }

    public void SettingFromAudioSourceToAudioSourceSettings(AudioSource audiosource, AudioSourceSettings settings)
    {
        settings.audioClip = audiosource.clip;

        settings.audioMixerGroup = audiosource.outputAudioMixerGroup;

        settings.mute = audiosource.mute;

        settings.bypassEffects = audiosource.bypassEffects;

        settings.bypassListenerEffects = audiosource.bypassListenerEffects;

        settings.bypassReverbZone = audiosource.bypassReverbZones;

        settings.playOnAwake = audiosource.playOnAwake;

        settings.loop = audiosource.loop;

        settings.priority = audiosource.priority;

        settings.volume = audiosource.volume;

        settings.pitch = audiosource.pitch;

        settings.stereoPan = audiosource.panStereo;

        settings.spatialBlend = audiosource.spatialBlend;

        settings.reverbZoneMix = audiosource.reverbZoneMix;

        settings.dopplerLevel = audiosource.dopplerLevel;

        settings.spread = audiosource.spread;

        settings.audioRolloffMode = audiosource.rolloffMode;

        settings.minDistance = audiosource.minDistance;

        settings.maxDistance = audiosource.maxDistance;

    }

    public void SettingFromScriptableToAudioSource(AudioSourceSettings settings, AudioSource audioSource)
    {
        audioSource.clip = settings.audioClip;

        audioSource.outputAudioMixerGroup = settings.audioMixerGroup;

        audioSource.mute = settings.mute;

        audioSource.bypassEffects = settings.bypassEffects;

        audioSource.bypassListenerEffects = settings.bypassListenerEffects;

        audioSource.bypassReverbZones = settings.bypassReverbZone;

        audioSource.playOnAwake = settings.playOnAwake;

        audioSource.loop = settings.loop;

        audioSource.priority = (int)settings.priority;

        audioSource.volume = settings.volume;

        audioSource.pitch = settings.pitch;

        audioSource.panStereo = settings.stereoPan;

        audioSource.spatialBlend = settings.spatialBlend;

        audioSource.reverbZoneMix = settings.reverbZoneMix;

        audioSource.dopplerLevel = settings.dopplerLevel;

        audioSource.spread = settings.spread;

        audioSource.rolloffMode = settings.audioRolloffMode;

        audioSource.minDistance = settings.minDistance;

        audioSource.maxDistance = settings.maxDistance;
    }
}
