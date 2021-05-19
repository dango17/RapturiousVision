using UnityEngine;
using UnityEngine.UI;

//Written by Daniel Oldham
//S1903729

public class PlayerAim : MonoBehaviour
{ 
    //Point from here
    public Transform headPos;

    //Each frame
    private void Update()
    { 
        //Project raycast
        RaycastHit hit;
        if (Physics.Raycast(headPos.position, headPos.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        { 
            //Draw in editor
            Debug.DrawRay(headPos.position, headPos.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            //Range check, can't click from afar
            float distance = Vector3.Distance(transform.position, hit.transform.position);
            if (distance <= 3f)
            { 
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.transform.GetComponent<KeypadKey>() != null)
                    { 
                        //Input 
                        hit.transform.GetComponent<KeypadKey>().SendKey();
                    }
                    else
                    {
                        //Do nothing
                    }
                }
            }
        }
    }
}

