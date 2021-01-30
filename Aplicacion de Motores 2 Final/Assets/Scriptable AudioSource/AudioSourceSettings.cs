using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "New Audio Settings", menuName = "Audio Settings")]
public class AudioSourceSettings : ScriptableObject
{
    public AudioSource audioSource;

    public AudioClip audioClip;

    public AudioMixerGroup audioMixerGroup;

    public bool mute;

    public bool bypassEffects;

    public bool bypassListenerEffects;

    public bool bypassReverbZone;

    public bool playOnAwake;

    public bool loop;

    public float priority;

    public float volume;

    public float pitch;

    public float stereoPan;

    public float spatialBlend;

    public float reverbZoneMix;

    public float dopplerLevel;

    public float spread;

    public AudioRolloffMode audioRolloffMode;

    public float minDistance;

    public float maxDistance;
}
