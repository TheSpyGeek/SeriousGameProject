using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]

public class changeColorBool : MonoBehaviour
{

    public Material matAlive;
    public Material matDead;

    public Health _health;

    private MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_health.isAlive()) {
            renderer.material = matAlive;
        } else {
            renderer.material = matDead;
        }
    }
}
