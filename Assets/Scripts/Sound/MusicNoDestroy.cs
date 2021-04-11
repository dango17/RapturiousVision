using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
