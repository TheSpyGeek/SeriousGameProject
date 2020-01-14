using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerPlayer : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
            animator.SetBool("running", true);
        }else{
            animator.SetBool("running", false);
        }

        if (Input.GetAxis("Attack") != 0 ){
            animator.SetBool("attacking", true);
        }else{
            animator.SetBool("attacking", false);
        }
    }
}
