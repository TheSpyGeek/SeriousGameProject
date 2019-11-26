using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Throwable : MonoBehaviour
{
    private bool grabbed;
    public GameObject canva;

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
        transform.rotation = t.rotation;
        _rigid.velocity = Vector3.zero;
        grabbed = true;
        canva.SetActive(false);
    }

    public void release() {
        //
        grabbed = false;
        transform.parent = backupParent;
        _rigid.velocity = Vector3.zero;
        canva.SetActive(true);
    }

    private void Update() {
        Debug.Log(transform.forward);
    }

    public void throwObj(float force) {

        grabbed = false;
        transform.parent = backupParent;
        canva.SetActive(true);
        _rigid.AddForce(transform.forward * force);
    }


}
