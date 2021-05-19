using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Written by Daniel Oldham
//S1903729

public class KeypadController : MonoBehaviour
{
    [Header("Passwords")]
    public string password;
    public int passwordLimit;
    public Text passwordText;

    [Header("Lights")]
    public GameObject DoorPowerOff;
    public GameObject DoorPowerOn; 

    public GameObject door;
    public Text PickUpPrompt; 

    //On start
    private void Start()
    {
        passwordText.text = "";
        door.GetComponent<BoxCollider>().enabled = false;
        DoorPowerOn.GetComponent<Light>().enabled = false;
        DoorPowerOff.GetComponent<Light>().enabled = true;
    }

    //In range
    public void OnTriggerEnter()
    {
        PickUpPrompt.gameObject.SetActive(true);
    }
    //Not in range
    public void OnTriggerExit()
    {
        PickUpPrompt.gameObject.SetActive(false);
    }
    //Key Inputs
    public void PasswordEntry(string number)
    {
        if (number == "Clear")
        {
            Clear();
            return;
        }
        else if(number == "Enter")
        {
            Enter();
            return;
        }

        int length = passwordText.text.ToString().Length;
        if(length<passwordLimit)
        {
            passwordText.text = passwordText.text + number;
        }
    }
    //Clear UI
    public void Clear()
    {
        passwordText.text = "";
        passwordText.color = Color.white;
    }
    //Enter the value
    private void Enter()
    { 
        //Password correct
        if (passwordText.text == password)
        {
            door.GetComponent<BoxCollider>().enabled = true;
            DoorPowerOn.GetComponent<Light>().enabled = true;
            DoorPowerOff.GetComponent<Light>().enabled = false;

            passwordText.color = Color.green;
            StartCoroutine(waitAndClear());
        }
        //Password wrong
        else
        {            
            passwordText.color = Color.red;
            StartCoroutine(waitAndClear());
        }
    }
    //Clear screen
    IEnumerator waitAndClear()
    {
        yield return new WaitForSeconds(0.75f);
        Clear();
    }


}
