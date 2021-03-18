using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySnap : MonoBehaviour
{
    public Transform BatteryDest;
    public Rigidbody rb;

    public GameObject PowerOff;
    public GameObject PowerOn;

    public GameObject DoorPowerOff;
    public GameObject DoorUnlocked; 

    public void Start()
    { 
       //Start off
       PowerOff.GetComponent<Light>().enabled = true;     
       PowerOn.GetComponent<Light>().enabled = false;
       
       //Door starts locked...Turn off box collider
        DoorPowerOff.GetComponent<BoxCollider>.enabled = false;
        //Door is locked, show red lock light
        DoorUnlocked.GetComponent<Light>().enabled = false; 
    }

    public void OnTriggerEnter(Collider col)
    {  
        if(col.tag == "Battery")
        {
            this.transform.position = BatteryDest.position;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            rb.GetComponent<Rigidbody>().freezeRotation = true;

            PowerOff.GetComponent<Light>().enabled = false;
            PowerOn.GetComponent<Light>().enabled = true;
        }      
    } 

    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Battery")
        {
            PowerOff.GetComponent<Light>().enabled = true;
            PowerOn.GetComponent<Light>().enabled = false;
        }           
    }
}
