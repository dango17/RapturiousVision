using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    public bool NotebookIsOpen;
    public GameObject NotebookScreen; 

    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Tab) && NotebookIsOpen == false)
        {
            NotebookScreen.SetActive(true);
            NotebookIsOpen = true; 
        } 
        else if(Input.GetKeyDown(KeyCode.Tab) && NotebookIsOpen == true)
        {
            NotebookScreen.SetActive(false);
            NotebookIsOpen = false; 
        }
    }  
}
