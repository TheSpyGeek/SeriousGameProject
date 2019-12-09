using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class garbageDestroyer : MonoBehaviour
{

    

    private Collider _colllider;

    // Start is called before the first frame update
    void Start()
    {
        _colllider = GetComponent<Collider>();
    }


    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Enemy")) {
            Health _heal;
            if(other.gameObject.TryGetComponent<Health>(out _heal)) {
                if(!_heal.isAlive()) {
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
