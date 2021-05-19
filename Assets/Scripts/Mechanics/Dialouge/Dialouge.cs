using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

[System.Serializable]
public class Dialouge 
{
    public string name; 

    [TextArea(3, 10)]
    public string[] sentences; 
}
