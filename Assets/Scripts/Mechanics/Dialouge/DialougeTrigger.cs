using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeTrigger : MonoBehaviour
{
    public Dialouge dialouge;
    public Text PickUpPrompt;

    public Text NotepadDiscovered;
    public Text NotePadUnknown; 

    public Text EnableThisInNotebook; 

    //Player is close, enable prompt
    public void OnTriggerEnter()
    {
        PickUpPrompt.gameObject.SetActive(true);
    }

    //Player is staying inside area
    void OnTriggerStay(Collider player)
    {
        //Press E, Open the logbook
        if (Input.GetKeyDown(KeyCode.E))
        {
            EnableThisInNotebook.gameObject.SetActive(true);

            NotePadUnknown.gameObject.SetActive(false);
            NotepadDiscovered.gameObject.SetActive(true); 

            StartCoroutine(FlashNoteBookPrompt());
            FindObjectOfType<DialogeManager>().StartDialouge(dialouge);
            PickUpPrompt.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PickUpPrompt.gameObject.SetActive(true);
            FindObjectOfType<DialogeManager>().EndDialouge();
        }
    } 

    IEnumerator FlashNoteBookPrompt()
    {
        yield return new WaitForSeconds(3);
        EnableThisInNotebook.gameObject.SetActive(false);
    }

    void OnTriggerExit(Collider player)
    {
        FindObjectOfType<DialogeManager>().EndDialouge();
        PickUpPrompt.gameObject.SetActive(false);
    }
}
