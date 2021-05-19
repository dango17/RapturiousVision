using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Written by Daniel Oldham
//S1903729

public class DialougeTrigger : MonoBehaviour
{ 
    [Header("Dialouge")]
    public Dialouge dialouge;
    public Text PickUpPrompt;
    public GameObject LogbookScreen; 

    [Header("NoteBook-Variables")]
    public Text NotepadDiscovered;
    public Text NotePadUnknown; 

    [Header("UI-Prompts")]
    public Text NotebookAddedPrompt;

    [Header("Minimap-Icon")]
    public GameObject minimapIconOff;

    public bool IsOpen;

    //Player is close, enable prompt
    public void OnTriggerEnter()
    {
        PickUpPrompt.gameObject.SetActive(true);
    }

    //Player is staying inside area
    void OnTriggerStay(Collider player)
    {
        //Press E, Open the logbook
        if (Input.GetKeyDown(KeyCode.E) && IsOpen == false)
        {
            LogbookScreen.SetActive(true);
            //Start Logbook Popup
            FindObjectOfType<DialogeManager>().StartDialouge(dialouge);
            //Player has opened logbook, set to true 
            IsOpen = true;          
            //Remove pick up UI promopt
            PickUpPrompt.gameObject.SetActive(false);
            //Turn off MiniMap Icon, player has already collected
            minimapIconOff.SetActive(false); 
            //Add notes to Notepad/Turn on and off
            NotePadUnknown.gameObject.SetActive(false);
            NotepadDiscovered.gameObject.SetActive(true); 
            //Start Coroutine to remove NoteUI Prompt
            StartCoroutine(FlashNoteBookPrompt());
            NotebookAddedPrompt.gameObject.SetActive(true);          
        }
        else if (Input.GetKeyDown(KeyCode.E) && IsOpen == true)
        {
            PickUpPrompt.gameObject.SetActive(true);
            LogbookScreen.SetActive(false);
            FindObjectOfType<DialogeManager>().EndDialouge();         
        }
    } 

    //Notify player has new notes
    IEnumerator FlashNoteBookPrompt()
    {
        yield return new WaitForSeconds(6);
        NotebookAddedPrompt.gameObject.SetActive(false);
    }
    //Player has left range of logbook
    void OnTriggerExit(Collider player)
    {
        LogbookScreen.SetActive(false);
        PickUpPrompt.gameObject.SetActive(false);
        FindObjectOfType<DialogeManager>().EndDialouge();
    }
}
