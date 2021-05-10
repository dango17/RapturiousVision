using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBattery : MonoBehaviour
{
    [Header("This Model")]
    public GameObject This;
    [Header("UI-Prompts")]
    public GameObject PickUpBatteryPrompt;
    public GameObject BatteryUISlot;
    [Header("HasBatterBool")]
    public GameObject BatteryHolder;

    public void Start()
    {
        BatteryHolder.GetComponent<BatteryInsert>().HasBattery = false; 
    }

    public void OnTriggerStay(Collider col)
    {
        PickUpBatteryPrompt.SetActive(true);  

        if (col.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                PickUpBatteryPrompt.SetActive(false);
                BatteryUISlot.SetActive(true); 
                BatteryHolder.GetComponent<BatteryInsert>().HasBattery = true;
                This.SetActive(false);             
            }
        }
    } 

    public void OnTriggerExit(Collider col)
    {
        PickUpBatteryPrompt.SetActive(false); 
    }
}
