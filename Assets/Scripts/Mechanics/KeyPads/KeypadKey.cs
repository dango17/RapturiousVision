using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class KeypadKey : MonoBehaviour
{ 
    //The button
    public string key;
    
    //Send that key to UI
    public void SendKey()
    {
        this.transform.GetComponentInParent<KeypadController>().PasswordEntry(key);
    }

}
