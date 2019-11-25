using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]

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
        textToFill.text = _health.currentHP + "/"+_health.nbHealthPoint;   
    }
}
