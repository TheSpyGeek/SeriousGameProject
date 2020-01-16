using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVillageWalk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetBool("running", true);
    }

}
