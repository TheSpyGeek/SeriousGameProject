using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVillageWalk : MonoBehaviour
{
    public float walkSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetBool("running", true);
    }

    private void Update() {
        Vector3 position = transform.position;
        position.z += walkSpeed * Time.deltaTime;
        transform.position = position;
    }
}
