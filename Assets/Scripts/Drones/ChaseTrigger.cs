using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class ChaseTrigger : MonoBehaviour
{
    //Player has hit specific radius, turn off patrol scripts 
    //Enable Chase related scripts

    public GameObject jumpScare;

    //Start this script false, is enabled true in 
    public void start()
    {
        GetComponent<Jumpscare>().enabled = false; 
    }
     
    public void OnTriggerEnter(Collider col)
    { 
        //Player check, stops enemy destorying itself
        if(col.tag == "Player")
        { 
            //Turn off Patol script
            GetComponent<PatrolDrone>().enabled = false;
            //Turn on Chase script
            GetComponent<EnemyPathFind>().enabled = true; 
            //Disable Sphere collider (Chase trigger)
            GetComponent<SphereCollider>().enabled = false;

            jumpScare.SetActive(true); 
      
        }   
    }

    //Player has escaped the enemy, need to stop it continually chasing 
    //the player, just destory it?...Breaks when it returns to patrol state 
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }         
    }
}
