using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LightSwitch : MonoBehaviour
{
    public GameObject light;
    public Text LightSwitchPrompt; 

    private bool on = false;

    public AudioSource ButtonClick; 

    public void Start()
    {
        //light.SetActive(false);
    }

    void OnTriggerStay(Collider player)
    {
        LightSwitchPrompt.gameObject.SetActive(true);

        if (player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            light.SetActive(true);
            on = true;
            ButtonClick.Play(); 
        }

        else if (player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            light.SetActive(false);
            on = false;
            ButtonClick.Play();
        }
    } 

    void OnTriggerExit(Collider player)
    {
        LightSwitchPrompt.gameObject.SetActive(false);
    }
}
