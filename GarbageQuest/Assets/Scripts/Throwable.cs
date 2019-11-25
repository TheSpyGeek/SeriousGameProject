using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Throwable : MonoBehaviour
{
    private bool grabbed;
    public GameObject canva;

    // Start is called before the first frame update
    void Start(){
        grabbed = false;
    }

    


    public void beGrabbed(Transform t) {
        transform.parent = t;
        grabbed = true;
        canva.SetActive(false);
    }

    public void throwObj(float force) {
        //transform.parent


        canva.SetActive(true);
    }


}
