using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class AttackScript : MonoBehaviour
{

    public int damageDeal = 1;
    public float attackspeed = 200;

    private float lastimeAttack = 0;

    private Collider _collider;




    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<Collider>();
        lastimeAttack = Time.time;
    }

    


    // si il peut ré attaquer en fonction de l'attack speed
    private bool canAttack() {
        return Time.time - lastimeAttack > attackspeed;
    }


    void OnTriggerStay(Collider other) {
        if(Input.GetButton("Attack") && canAttack()) {
            lastimeAttack = Time.time;
            Health _health;
            if(other.gameObject.CompareTag("Enemy")) { // other.gameObject.tag == "Enemy"   allocates memory :) Thanks @Vexe :D
                if(other.gameObject.TryGetComponent<Health>(out _health)) {
                    _health.getHit(damageDeal);
                }
            }
        }
        
    }


}
