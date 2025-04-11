using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private float detectionRange = 20f;

    private NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancePlaer = Vector3.Distance(transform.position, player.position);
        if (distancePlaer < detectionRange)
        {
            agent.SetDestination(player.position);

        }

    }
}