using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Written by Daniel Oldham
//S1903729

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI; 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume(); 
            } 
            else
            {
                Pause(); 
            }
        }
    } 

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false; 
    } 

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    } 

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    } 

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
