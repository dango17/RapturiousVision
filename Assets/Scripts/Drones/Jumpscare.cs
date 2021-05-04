using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Jumpscare : MonoBehaviour
{
    public GameObject EvilDroneUI;
    public GameObject EnemyChasing;
    public GameObject Rendering; 

    //Enemy has got the player, disable actual enemy, & enable the UI
    //jumpscare version, after that disable the UI version 
    public void OnTriggerEnter(Collider col)
    { 
        //enemy has hit player
        if (col.tag == "Player")
        {
            //Can't destory object as whole, needs relevant scripts, just disable 
            //all renderable parts on the actual model instead for now
            Rendering.SetActive(false); 
            //Turn on the Drone parented to player
            EvilDroneUI.SetActive(true);
            //Start Coroutine, only want it to last so long
            StartCoroutine(LastForSoLong()); 

            //Play big scary loud noise here!!!
        }     
    } 

    IEnumerator LastForSoLong()
    { 
        //Keep jumpscare on screen for so Long
        yield return new WaitForSeconds(5);
        //Turn off jumpscare now
        EvilDroneUI.SetActive(false);
        //Can now also destory the enemy as a whole, dont need it anymore
        Destroy(EnemyChasing.gameObject);

        //Player is dead, send them to the shadow realm 
        SceneManager.LoadScene("Death");
    } 
}
