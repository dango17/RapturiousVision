using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCardLockedDoor : MonoBehaviour
{
    public GameObject KeyCardDoor;
    public GameObject UIKeycard;
    public GameObject LockedLight;
    public GameObject UnlockedLight; 

    void Start()
    {
        KeyCardDoor.GetComponent<BoxCollider>().enabled = false;
        UIKeycard.GetComponent<RawImage>().enabled = false;
        LockedLight.GetComponent<Light>().enabled = true;
       
    }

    void OnTriggerStay(Collider player)
    {
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
