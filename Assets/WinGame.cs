using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class WinGame : MonoBehaviour
{
    public GameObject ThankyouMessage; 

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            ThankyouMessage.SetActive(true);
            StartCoroutine(Mainmenu());
        }
    } 
    IEnumerator Mainmenu()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("MainMenu"); 
    }
}
