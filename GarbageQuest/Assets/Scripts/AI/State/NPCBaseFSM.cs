using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCBaseFSM : StateMachineBehaviour
{
    public GameObject NPC;
    public NavMeshAgent navMeshAgent;

    public GameObject target;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC = animator.gameObject;
        navMeshAgent = NPC.GetComponent<NPCBaseAI>().GetNavMeshAgent();
        target = NPC.GetComponent<NPCBaseAI>().GetTarget();
    }
}
