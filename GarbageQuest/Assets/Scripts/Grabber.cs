using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FieldOfView))]


public class Grabber : MonoBehaviour
{

    private FieldOfView field;
    public float throwForce = 6.0f;

    private Collider _collider;

    private bool isGrabbing;
    private GameObject objGrabbed;

    // Start is called before the first frame update
    void Start()
    {
        isGrabbing = false;
        field = GetComponent<FieldOfView>();
    }
   


    void Update() {

        // si l'objet est détruit par la poubelle
        if(isGrabbing && objGrabbed == null) {
            isGrabbing = false;
            objGrabbed = null;
            //Debug.Log("Destroyed");
        }


        if(Input.GetButtonDown("Use") && !isGrabbing) {

            List<Transform> objs = field.getListVisible();

            if(objs.Count > 0){
                GameObject objToGrab = objs[0].gameObject;

                Health _health;
                Throwable _throw;
                
                if(objToGrab.TryGetComponent<Throwable>(out _throw)) {
                    if(objToGrab.TryGetComponent<Health>(out _health)) {
                        if(!_health.isAlive()) {
                            _throw.beGrabbed(this.transform);
                            isGrabbing = true;
                            objGrabbed = objToGrab;
                        }
                    }
                }
            }
            
        } else if(Input.GetButtonDown("Use") && isGrabbing) {
            Throwable _throw;
            if(objGrabbed.TryGetComponent<Throwable>(out _throw)) {
                _throw.release();
                isGrabbing = false;
                objGrabbed = null;
            }

        } else if(Input.GetButtonDown("Attack") && isGrabbing) {
            Throwable _throw;
            if(objGrabbed.TryGetComponent<Throwable>(out _throw)) {
                _throw.throwObj(throwForce);
                isGrabbing = false;
                objGrabbed = null;
            }

        }

    }


}
