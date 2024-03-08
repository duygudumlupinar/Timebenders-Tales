using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnOff : MonoBehaviour
{
    private AudioSource musicSource;
    private bool musicPlaying;
    private void Start()
    {
        musicPlaying = true;
        musicSource = GetComponent<AudioSource>();
    }
    public void TurnMusicOnOff()
    {
        if (musicPlaying)
        {
            musicSource.Stop();
            musicPlaying = false;
        }
        else
        {
            musicSource.Play();
            musicPlaying = true;
        }
    }
}
