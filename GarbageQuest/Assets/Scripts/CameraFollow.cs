using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;

    // Update is called once per frame
    void LateUpdate(){
        
        Vector3 pos = transform.TransformPoint(target.transform.position);

        //Vector3 offset = transform.position - target.transform.position;
        transform.position = target.transform.position + offset;
        transform.LookAt(target.transform.position);

        
    }
}
