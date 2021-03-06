using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
