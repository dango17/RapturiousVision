using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips; 
    private AudioSource audioSource; 

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false; 
    } 

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play(); 
        }
    }
}
