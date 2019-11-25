using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Throwable))]

public class displayHealth : MonoBehaviour
{
    public Text textToFill;

    private Health _health;

    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(_health.isAlive()) {
            textToFill.text = _health.getCurrentHealth() + "/" + _health.nbHealthPoint;
        } else {
            textToFill.text = "Grab it!";
        }
    }
}
