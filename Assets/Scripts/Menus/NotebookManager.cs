using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    public static bool NotebookIsOpen = false;
    public GameObject NotebookScreen; 

    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Tab) && NotebookIsOpen == false)
        {
            NotebookScreen.SetActive(true);
            NotebookIsOpen = true; 
        }
        if (Input.GetKeyDown(KeyCode.E) && NotebookIsOpen == true)
        {
            NotebookIsOpen = false;
            NotebookScreen.SetActive(false);
        }
    } 
}
