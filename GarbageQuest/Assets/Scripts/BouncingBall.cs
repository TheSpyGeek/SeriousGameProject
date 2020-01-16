using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]

public class BouncingBall : MonoBehaviour
{

    public LayerMask m_layer;
    public float velocityDiviser = 0.5f;

    private Rigidbody m_rigidbody;
    private Vector3 lastFrameVelocity;


    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lastFrameVelocity = m_rigidbody.velocity;
    }

    private void OnCollisionEnter(Collision collision) {
        //if(collision.gameObject.layer == m_layer) {
        bounce(collision.contacts[0].normal);
        //}
    }


    void bounce(Vector3 normal) {
        //Vector3 velocity = m_rigidbody.velocity;
        //Debug.Log(lastFrameVelocity);
        Vector3 velocity = Vector3.Reflect(lastFrameVelocity, normal);
        Debug.Log(velocity);
        m_rigidbody.velocity = velocity* velocityDiviser;
    }
}
