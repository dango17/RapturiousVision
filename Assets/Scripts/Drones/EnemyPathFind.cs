using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Daniel Oldham
//S1903729

public class EnemyPathFind : MonoBehaviour
{
    public GameObject EnemyDest;
    UnityEngine.AI.NavMeshAgent EnemyAgent; 

    // Start is called before the first frame update
    void Start()
    {
        EnemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAgent.SetDestination(EnemyDest.transform.position);
    }
}
