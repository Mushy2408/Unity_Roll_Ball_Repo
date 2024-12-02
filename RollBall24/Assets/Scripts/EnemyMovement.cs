using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent NavMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent = GetComponent <NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            NavMeshAgent.SetDestination(player.position);
        }
    }
}