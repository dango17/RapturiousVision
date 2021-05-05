using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVoiceTrigger : MonoBehaviour
{
    public AudioSource AIVoiceHere;

   public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            AIVoiceHere.Play(); 
        }
    }
}
