using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Written by Daniel Oldham
//S1903729

public class DialogeManager : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;

    private Queue<string> sentences; 

    void Start()
    {
        sentences = new Queue<string>();
    } 

    public void StartDialouge(Dialouge dialouge)
    {
        //Name of Logbook writter
        nameText.text = dialouge.name; 

        sentences.Clear(); 

        //Add each sentence to que
        foreach(string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }
        //Move on
        DisplayNextSentence();
    } 

    public void DisplayNextSentence()
    { 
        //Non left
        if(sentences.Count == 0)
        {
            EndDialouge();
            return;
        }
       string sentence = sentences.Dequeue();
       dialougeText.text = sentence; 
    } 

    public void EndDialouge()
    {        
        //End
        //Do nothing, close inside the Trigger script
    }
}
