using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class TurnOffCore : MonoBehaviour
{ 
    [Header("Door Lock")]
    public GameObject DoorLock;
    public GameObject DoorLockLight;
    [Header("Core")]
    public GameObject CoreLight;
    public GameObject Core; 
    public GameObject TurnOffPrompt;
    public AudioSource PowerDown;
    public GameObject This;
    [Header("Door Unlock")]
    public GameObject DoorUnlock;
    public GameObject LightOn;
    public GameObject LightOff;



    public void OnTriggerStay(Collider col)
    {
        TurnOffPrompt.SetActive(true); 

        if(col.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                DoorLock.GetComponent<BoxCollider>().enabled = false;
                This.GetComponent<BoxCollider>().enabled = false;
                DoorUnlock.GetComponent<BoxCollider>().enabled = true;
                Core.GetComponent<AsteroidRotation>().enabled = false; 

                TurnOffPrompt.SetActive(false);
                PowerDown.Play(); 

                CoreLight.SetActive(false);
                LightOn.SetActive(true);
                LightOff.SetActive(false); 
            }
        }
    } 

    public void OnTriggerExit()
    {
        TurnOffPrompt.SetActive(false);
    }
}
