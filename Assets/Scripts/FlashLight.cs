using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject FlashLightObj; 

    // Start is called before the first frame update
    void Start()
    {
        FlashLightObj.GetComponent<Light>().enabled = true; 
    }

    
    public void TurnOffFlashLight()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            FlashLightObj.GetComponent<Light>().enabled = false;
        } 
        else
        {
            FlashLightObj.GetComponent<Light>().enabled = true;
        }
    }
}
