using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class MusicNoDestroy : MonoBehaviour
{
    private AudioSource _audioSource;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
        // GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
