using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        GetComponent<PatrolDrone>().enabled = false;
        GetComponent<EnemyPathFind>().enabled = true;
    }
}
