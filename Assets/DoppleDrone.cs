using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoppleDrone : MonoBehaviour
{
    public GameObject EvilDroneUI;
    

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            EvilDroneUI.SetActive(true);
            StartCoroutine(LastForSoLong()); 
        } 
    } 

    IEnumerator LastForSoLong()
    {
        yield return new WaitForSeconds(3);
        EvilDroneUI.SetActive(false);
        GetComponent<SphereCollider>().enabled = false; 
    }
}
