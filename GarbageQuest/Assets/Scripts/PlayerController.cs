using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0.2f;


    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start(){
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){

        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");
        move.y = Input.GetAxis ("Vertical");

        Vector3 position = transform.position;
        position.x += move.x*speed;
        position.z += move.y*speed;


        transform.position = position;
    }
}
