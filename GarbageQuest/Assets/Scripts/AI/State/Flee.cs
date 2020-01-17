using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Flee : NPCBaseFSM
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {   
        Vector3 dirToMe = NPC.transform.position - target.transform.position;
        navMeshAgent.SetDestination(NPC.transform.position + dirToMe);
    }
}
