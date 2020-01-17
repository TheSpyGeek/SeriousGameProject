using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Coward : MonoBehaviour
{
    public Transform target;
    public float distanceToFlee = 3f;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (!target)
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 dirToMe = transform.position - target.position;

        if (dirToMe.magnitude < 3f)
        {
            agent.SetDestination(transform.position + dirToMe);
        }
    }
}
