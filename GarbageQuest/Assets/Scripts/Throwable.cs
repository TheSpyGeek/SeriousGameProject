using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Throwable : MonoBehaviour
{
    private bool grabbed;
    public GameObject canva;

    private Transform backupParent;

    // Start is called before the first frame update
    void Start(){
        grabbed = false;
        backupParent = transform.parent;
    }

    


    public void beGrabbed(Transform t) {
        transform.parent = t;
        grabbed = true;
        canva.SetActive(false);
    }

    public void release() {
        //
        grabbed = false;
        transform.parent = backupParent;
        canva.SetActive(true);
    }

    public void throwObj(float force) {
        //

        grabbed = false;
        transform.parent = backupParent;
        canva.SetActive(true);
    }


}
