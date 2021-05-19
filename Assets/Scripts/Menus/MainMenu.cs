using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Written by Daniel Oldham
//S1903729

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    } 

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit(); 
    }
}
