using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Throwable : MonoBehaviour
{
    private bool grabbed;


    public GameObject canvas;


    public Vector3 offset = new Vector3(0,-0.5f,1.5f);


    private Rigidbody _rigid;

    private Transform backupParent;

    // Start is called before the first frame update
    void Start(){
        grabbed = false;
        backupParent = transform.parent;
        _rigid = GetComponent<Rigidbody>();
    }

    


    public void beGrabbed(Transform t) {
        transform.parent = t;
        transform.localPosition = offset;
        transform.rotation = t.rotation;
        _rigid.velocity = Vector3.zero;
        _rigid.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ  ;
        grabbed = true;
        canvas.SetActive(false);
    }

    public void release() {
        //
        grabbed = false;
        transform.parent = backupParent;
        _rigid.velocity = Vector3.zero;
        _rigid.constraints =  RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ  ;
        canvas.SetActive(true);
    }

  
    public void throwObj(float force) {

        grabbed = false;
        transform.parent = backupParent;
        canvas.SetActive(true);
        _rigid.constraints =  RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ  ;
        _rigid.AddForce(transform.forward * force);
    }


}
