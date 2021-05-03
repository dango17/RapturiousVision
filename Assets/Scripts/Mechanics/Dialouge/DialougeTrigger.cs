using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeTrigger : MonoBehaviour
{
    public Dialouge dialouge;
    public Text PickUpPrompt;

    public bool DialougeActive = false; 

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
        if (Input.GetKeyDown(KeyCode.E) && DialougeActive == true)
        {
            DialougeActive = true; 
            FindObjectOfType<DialogeManager>().StartDialouge(dialouge);
            PickUpPrompt.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && DialougeActive == false)
        {
            DialougeActive = false; 
            PickUpPrompt.gameObject.SetActive(true);
            FindObjectOfType<DialogeManager>().EndDialouge();
        }
    } 

    void OnTriggerExit(Collider player)
    {
        FindObjectOfType<DialogeManager>().EndDialouge();
        PickUpPrompt.gameObject.SetActive(false);
    }
}
