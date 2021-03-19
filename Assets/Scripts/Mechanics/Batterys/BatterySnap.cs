using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySnap : MonoBehaviour
{
    //Battery Variables
    [Header("Batterys Grab pos & it's Rigidbody")]
    public Transform BatteryDest;
    public Rigidbody rb;

    //Battery Slot lights
    [Header("Battery Slot Lights")]
    public GameObject BatteryPowerOff;
    public GameObject BatteryPowerOn;

    //Door lock lights
    [Header("Doors Lights")]
    public GameObject DoorPowerOff;
    public GameObject DoorPowerOn;

    [Header("Door that battery unlocks")]
    //Door battery will unlock
    public GameObject DoorEnable;


    public void Start()
    {  
        //Battery Holder Lights
        //Off Lights on (Red), On lights off (Green)
        BatteryPowerOff.GetComponent<Light>().enabled = true;     
        BatteryPowerOn.GetComponent<Light>().enabled = false;

        //Door script off
        //Off Lights on (Red), On lights off (Green)
        DoorEnable.GetComponent<DoorOpenTrue>().enabled = false;
        DoorPowerOff.GetComponent<Light>().enabled = true;
        DoorPowerOn.GetComponent<Light>().enabled = false;
    }

    //Once battery touches slot position
    public void OnTriggerEnter(Collider col)
    {  
        if(col.tag == "Battery")
        { 
            //Battery Detected, 
            //Lock into position on release
            this.transform.position = BatteryDest.position;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            rb.GetComponent<Rigidbody>().freezeRotation = true;
            // & Change lights
            BatteryPowerOff.GetComponent<Light>().enabled = false;
            BatteryPowerOn.GetComponent<Light>().enabled = true;
            //Enable door script true
            DoorEnable.GetComponent<DoorOpenTrue>().enabled = true;
            DoorPowerOff.GetComponent<Light>().enabled = false;
            DoorPowerOn.GetComponent<Light>().enabled = true;
        }      
    }

    //Battery has left battery slot
    //Once again disable everything... 
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Battery")
        {
            //Off Lights on (Red), On lights off (Green)
            BatteryPowerOff.GetComponent<Light>().enabled = true;
            BatteryPowerOn.GetComponent<Light>().enabled = false;

            //Door script off
            //Off Lights on (Red), On lights off (Green)
            DoorEnable.GetComponent<DoorOpenTrue>().enabled = false;
            DoorPowerOff.GetComponent<Light>().enabled = true;
            DoorPowerOn.GetComponent<Light>().enabled = false;
        }           
    }
}
