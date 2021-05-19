﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Written by Daniel Oldham
//S1903729

public class CheatDeath : MonoBehaviour
{
    public GameObject CheatdeathUI; 

    public void OnTriggerStay()
    {
        CheatdeathUI.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Respawn1");
        }
    }
    public void OnTriggerExit()
    {
        CheatdeathUI.SetActive(false);
    }
}
