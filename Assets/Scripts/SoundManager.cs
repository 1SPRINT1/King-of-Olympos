using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public bool isSoundOn = true;

    private AudioSource[] audioSources;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        audioSources = FindObjectsOfType<AudioSource>();
    }

    public void ToggleSound()
    {
        isSoundOn = !isSoundOn;

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.mute = !isSoundOn;
        }
    }
    public void ToggleON()
    {
        isSoundOn = true;
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.mute = isSoundOn;
        }
    }
}
