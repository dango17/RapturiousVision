using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class LightFlicker : MonoBehaviour
{
    public Light lightFlicker;

    public float MinTime;
    public float MaxTime;
    public float Timer;

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
        }
    }
}
