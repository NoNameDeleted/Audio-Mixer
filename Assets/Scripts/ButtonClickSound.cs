using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clickSound;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>(); //.onClick.AddListener(PlayClickSound);
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(PlayClickSound);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(PlayClickSound);
    }

    private void PlayClickSound()
    {
        _audioSource.PlayOneShot(_clickSound);
    }
}

