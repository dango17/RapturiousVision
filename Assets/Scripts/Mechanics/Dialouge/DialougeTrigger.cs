using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeTrigger : MonoBehaviour
{ 
    [Header("Dialouge")]
    public Dialouge dialouge;
    public Text PickUpPrompt;

    [Header("NoteBook-Variables")]
    public Text NotepadDiscovered;
    public Text NotePadUnknown; 

    [Header("UI-Prompts")]
    public Text NotebookAddedPrompt;

    [Header("Minimap-Icon")]
    public GameObject minimapIconOff; 

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
            NotebookAddedPrompt.gameObject.SetActive(true);
            minimapIconOff.SetActive(false); 

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
        NotebookAddedPrompt.gameObject.SetActive(false);
    }

    void OnTriggerExit(Collider player)
    {
        FindObjectOfType<DialogeManager>().EndDialouge();
        PickUpPrompt.gameObject.SetActive(false);
    }
}
