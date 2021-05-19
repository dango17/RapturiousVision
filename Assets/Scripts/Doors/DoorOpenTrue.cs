using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//Written by Daniel Oldham
//S1903729

public class DoorOpenTrue : MonoBehaviour
{
    // Sliding door
    public enum OpenDirection { x, y, z }
    public OpenDirection direction = OpenDirection.y;
    public float openDistance = 3f; 
    public float openSpeed = 2.0f; 
    public Transform doorBody; 

    public AudioSource doorSlide; 

    bool open = false;

    Vector3 defaultDoorPosition;

    void Start()
    {
        if (doorBody)
        {
            defaultDoorPosition = doorBody.localPosition;
        }
    }

    // Main function
    void Update()
    {
        if (!doorBody)
            return;

        if (direction == OpenDirection.x)
        {
            doorBody.localPosition = new Vector3(Mathf.Lerp(doorBody.localPosition.x, defaultDoorPosition.x + (open ? openDistance : 0), Time.deltaTime * openSpeed), doorBody.localPosition.y, doorBody.localPosition.z);
        }
        else if (direction == OpenDirection.y)
        {
            doorBody.localPosition = new Vector3(doorBody.localPosition.x, Mathf.Lerp(doorBody.localPosition.y, defaultDoorPosition.y + (open ? openDistance : 0), Time.deltaTime * openSpeed), doorBody.localPosition.z);
        }
        else if (direction == OpenDirection.z)
        {
            doorBody.localPosition = new Vector3(doorBody.localPosition.x, doorBody.localPosition.y, Mathf.Lerp(doorBody.localPosition.z, defaultDoorPosition.z + (open ? openDistance : 0), Time.deltaTime * openSpeed));
        }
    }

    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            open = true;
            doorSlide.Play(); 

        }
    }

    // Deactivate the Main function when Player exit the trigger area
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //doorSlide.Play();
            open = false;
        }
    }
}
