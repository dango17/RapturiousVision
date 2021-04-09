using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
   
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false; 
        GetComponent<Rigidbody>().freezeRotation = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    } 

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;  
        GetComponent<Rigidbody>().freezeRotation = false;  
    }
}
