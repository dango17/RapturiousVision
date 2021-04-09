using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeTrigger : MonoBehaviour
{
    public Dialouge dialouge;
    public Text PickUpPrompt;

    void start()
    {
        //PickUpPrompt.gameObject.SetActive(false); 
    }

    public void OnTriggerEnter()
    {
        PickUpPrompt.gameObject.SetActive(true);
    }

    void OnTriggerStay(Collider player)
    { 
        if(Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogeManager>().StartDialouge(dialouge);
            PickUpPrompt.gameObject.SetActive(false);
        }                             
    } 

    void OnTriggerExit(Collider player)
    {
        FindObjectOfType<DialogeManager>().EndDialouge();
        PickUpPrompt.gameObject.SetActive(false);
    }
}
