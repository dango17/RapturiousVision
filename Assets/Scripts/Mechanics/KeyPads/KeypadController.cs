using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadController : MonoBehaviour
{
    [Header("Passwords")]
    public string password;
    public int passwordLimit;
    public Text passwordText;

    [Header("Lights")]
    public GameObject DoorPowerOff;
    public GameObject DoorPowerOn; 

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    public GameObject door;
    public Text PickUpPrompt; 

    private void Start()
    {
        passwordText.text = "";
        door.GetComponent<DoorOpenTrue>().enabled = false;
        DoorPowerOn.GetComponent<Light>().enabled = false;
        DoorPowerOff.GetComponent<Light>().enabled = true;
    }

    public void OnTriggerEnter()
    {
        PickUpPrompt.gameObject.SetActive(true);
    }

    public void OnTriggerExit()
    {
        PickUpPrompt.gameObject.SetActive(false);
    }

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

    public void Clear()
    {
        passwordText.text = "";
        passwordText.color = Color.white;
    }

    private void Enter()
    {
        if (passwordText.text == password)
        {
            door.GetComponent<DoorOpenTrue>().enabled = true;
            DoorPowerOn.GetComponent<Light>().enabled = true;
            DoorPowerOff.GetComponent<Light>().enabled = false;

            if (audioSource != null)
                audioSource.PlayOneShot(correctSound);

            passwordText.color = Color.green;
            StartCoroutine(waitAndClear());
        }
        else
        {
            if (audioSource != null)
                audioSource.PlayOneShot(wrongSound);

            passwordText.color = Color.red;
            StartCoroutine(waitAndClear());
        }
    }

    IEnumerator waitAndClear()
    {
        yield return new WaitForSeconds(0.75f);
        Clear();
    }


}
