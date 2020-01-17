using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCBaseAI : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private Health health;

    public GameObject GetTarget()
    {
        return target;
    }

    public NavMeshAgent GetNavMeshAgent()
    {
        return navMeshAgent;
    }

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        health = GetComponent<Health>();

        if (!target)
            target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        animator.SetFloat("distance", Vector3.Distance(transform.position, target.transform.position));
        if (!health.isAlive())
            animator.SetBool("isKO", true);
    }
}
