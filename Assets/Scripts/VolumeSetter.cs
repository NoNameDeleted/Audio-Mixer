using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetter : MonoBehaviour
{
    [SerializeField] private AudioMixer _masterMixer;

    private readonly string MusicVolume = nameof(MusicVolume);
    private readonly string SoundsVolume = nameof(SoundsVolume);
    private readonly string OverallVolume = nameof(OverallVolume);

    private int _volumeScale = 20;

    public void SetMusicVolume(float soundLevel)
    {
        _masterMixer.SetFloat(MusicVolume, Mathf.Log(soundLevel) * _volumeScale);
    }

    public void SetSoundVolume(float soundLevel)
    {
        _masterMixer.SetFloat(SoundsVolume, Mathf.Log(soundLevel) * _volumeScale);
    }

    public void SetOverallVolume(float soundLevel)
    {
        _masterMixer.SetFloat(OverallVolume, Mathf.Log(soundLevel) * _volumeScale);
    }
}
