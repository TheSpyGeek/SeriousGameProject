using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothTransformMove : MonoBehaviour
{
    public Transform endMarker;
    public float m_speed = 1.2f;

    void Update() {

        transform.position = Vector3.Lerp(transform.position, new Vector3(endMarker.position.x, transform.position.y, endMarker.position.z), Time.deltaTime* m_speed);
    }
}
