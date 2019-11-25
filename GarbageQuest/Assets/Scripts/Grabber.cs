using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Collider))]

public class Grabber : MonoBehaviour
{

    public float throwForce = 6.0f;

    private Collider _collider;

    private bool isGrabbing;

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<Collider>();
        isGrabbing = false;
    }


    private void Update() {
        if(Input.GetButton("Use")) {
            Debug.Log("Use");
        }
    }


    void OnTriggerStay(Collider other) {
        if(Input.GetButtonDown("Use") && !isGrabbing) {
            Health _health;
            Throwable _throw;
            
            if(other.gameObject.TryGetComponent<Throwable>(out _throw)) {
                if(other.gameObject.TryGetComponent<Health>(out _health)) {
                    if(!_health.isAlive()) {
                        _throw.beGrabbed(transform);
                        isGrabbing = true;
                    }
                }
            }
            
        } else if(Input.GetButtonDown("Use") && isGrabbing) {
            Throwable _throw;
            if(other.gameObject.TryGetComponent<Throwable>(out _throw)) {
                _throw.release();
                isGrabbing = false;
            }
        } else if(Input.GetButtonDown("Attack") && isGrabbing) {
            Throwable _throw;
            if(other.gameObject.TryGetComponent<Throwable>(out _throw)) {
                _throw.throwObj(throwForce);
                isGrabbing = false;
            }
        }

    }

}
