using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool lockedByPassword;
    public GameObject KeyPadDoor;

    public void OpenClose()
    {
        if (lockedByPassword)
        {
            
            Debug.Log("Locked by password");
            KeyPadDoor.GetComponent<DoorOpenTrue>().enabled = true;
            return;
        } 
      
       
    }
}
