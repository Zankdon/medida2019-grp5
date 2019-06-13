using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource sound;
    public static AudioManager instance = null;
    public AudioClip right;
    public AudioClip wrong;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void playRight()
    {
        sound.clip = right;
        sound.Play();
    }

    public void playWrong()
    {
        sound.clip = wrong;
        sound.Play();
    }
}
