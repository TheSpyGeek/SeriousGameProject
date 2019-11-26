using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]

public class displayActionArea : MonoBehaviour
{

    private SphereCollider _collider;

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<SphereCollider>();
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        

        float radius = _collider.radius * transform.lossyScale.x ;
        
        Gizmos.DrawSphere(transform.position, radius);
    }

}
