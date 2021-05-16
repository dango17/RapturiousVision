using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatDeath : MonoBehaviour
{
    public GameObject CheatdeathUI; 

    public void OnTriggerStay()
    {
        CheatdeathUI.SetActive(true);
    }
    public void OnTriggerExit()
    {
        CheatdeathUI.SetActive(false);
    }
}
