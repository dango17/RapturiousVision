using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
    public Dialouge dialouge; 

    void OnTriggerStay(Collider player)
    { 
        if(Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogeManager>().StartDialouge(dialouge);
        }
        
    }
}
