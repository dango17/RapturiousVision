using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Written by Daniel Oldham
//S1903729

public class KeyCardLockedDoor : MonoBehaviour
{ 
    //Door to unlock
    public GameObject KeyCardDoor;
    //Keycard on UI
    public GameObject UIKeycard;
    //Red light = start false
    public GameObject LockedLight;
    //Green light = start active 
    public GameObject UnlockedLight; 

    void Start()
    {
        KeyCardDoor.GetComponent<BoxCollider>().enabled = false;
        UIKeycard.GetComponent<RawImage>().enabled = false;
        LockedLight.GetComponent<Light>().enabled = true;
       
    }

    void OnTriggerStay(Collider player)
    { 
        //Player is in range to pick up object
        if (player.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {          
            Destroy(gameObject);       
            KeyCardDoor.GetComponent<BoxCollider>().enabled = true;
            UIKeycard.GetComponent<RawImage>().enabled = true;
            LockedLight.GetComponent<Light>().enabled = false;
            UnlockedLight.GetComponent<Light>().enabled = true;
        } 
    }
}
