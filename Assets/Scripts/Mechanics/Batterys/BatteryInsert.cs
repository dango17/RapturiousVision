using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryInsert : MonoBehaviour
{
    [Header("Has battery?")]
    public bool HasBattery = false;

    [Header("This(BoxCollider)")]
    public GameObject This;
    [Header("Battery ModelOnSlot")]
    public GameObject batteryIn;
    [Header("UI-Prompt")]
    public GameObject PutBatteryInPrompt;
    [Header("Battery Holder Lights")]
    public GameObject OffLight;
    public GameObject OnLight;
    [Header("DoorLights")]
    public GameObject OnDoor;
    public GameObject OffDoor;
    [Header("UI Icon")]
    public GameObject BatteryUISlot;
    [Header("DoorToUnlock")]
    public GameObject DoorToUnlock; 


    public void Start()
    {
        OffLight.SetActive(true);
        OnLight.SetActive(false);

        OffDoor.SetActive(true); 
        OnDoor.SetActive(false);
    }

    public void OnTriggerStay(Collider col)
    {
        PutBatteryInPrompt.SetActive(true); 

        if(HasBattery == true && (Input.GetKeyDown(KeyCode.E)))
        {
            PutBatteryInPrompt.SetActive(false);
            batteryIn.SetActive(true);
            HasBattery = false;
            BatteryUISlot.SetActive(false);

            DoorToUnlock.GetComponent<BoxCollider>().enabled = true;
            This.GetComponent<BoxCollider>().enabled = false;

            OffLight.SetActive(false);
            OnLight.SetActive(true);

            OffDoor.SetActive(false);
            OnDoor.SetActive(true);
        }
    } 

    public void OnTriggerExit(Collider col)
    {
        PutBatteryInPrompt.SetActive(false); 
    }
}
