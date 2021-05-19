using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class LookAtPlayer : MonoBehaviour
{
    public GameObject player; 

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform); 
    }
}
