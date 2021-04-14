using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class KeyCardDoor : MonoBehaviour
{ 
    [Header("Door to unlock on collection")]
    public GameObject UnlockthisDoor;
    [Header("Turn on & off icons on InventSlots")]
    public GameObject IconOn;
    public GameObject IconOff;
    [Header("UI Prompt")]
    public Text KeyCardText;
    [Header("KeyCard Model")]
    public GameObject KeycardModel;
    [Header("Lights")]
    public GameObject OffLight;
    public GameObject OnLight; 


    public void OnTriggerEnter()
    {
        KeyCardText.gameObject.SetActive(true);
    }

    public void OnTriggerExit()
    {
        KeyCardText.gameObject.SetActive(false);
    }

    public void OnTriggerStay(Collider col)
    {         
        //If player presses E inside range of keycard
        if(Input.GetKeyDown(KeyCode.E))
        { 
            //Unlock door that requires the keycard
            UnlockthisDoor.GetComponent<BoxCollider>().enabled = true; 
            //Turn on Keycard icon in Invent
            IconOn.gameObject.SetActive(true); 
            //Turn off blank slot on taskbar
            IconOff.SetActive(false);
            //Disable the keycard on collect, cannot destroy game object
            KeycardModel.SetActive(false);
            //Disable the box collider on keycard
            KeycardModel.GetComponent<BoxCollider>().enabled = false;
            KeyCardText.gameObject.SetActive(false);

            //Door Unlocked, switch lights to help visualise to player
            OffLight.SetActive(false);
            OnLight.SetActive(true);

        }
    } 

  
}
