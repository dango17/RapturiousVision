using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public AudioSource AIVoiceHere2;

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            AIVoiceHere2.Play();
        }
    }
}
