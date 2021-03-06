using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light lightFlicker;

    public float MinTime;
    public float MaxTime;
    public float Timer;

    public AudioSource AS;
    public AudioClip LightAudio;

    void start ()
    {
        Timer = Random.Range(MinTime, MaxTime);
    } 

    void Update()
    {
        Flicker(); 
    }

    void Flicker()
    {
        if (Timer > 0)
            Timer -= Time.deltaTime;

        if(Timer<=0)
        {
            lightFlicker.enabled = !lightFlicker.enabled;
            Timer = Random.Range(MinTime, MaxTime);
            AS.PlayOneShot(LightAudio);
        }
    }
}
