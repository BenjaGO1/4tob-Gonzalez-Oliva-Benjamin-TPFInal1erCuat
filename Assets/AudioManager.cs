using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    public void PLayClip()
    {
        source.clip = clip;
        source.Play();
    }
}
