using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FieldOfView))]

public class AttackScript : MonoBehaviour
{

    public int damageDeal = 1;
    public float attackspeed = 1;

    private float lastimeAttack = 0;

    private FieldOfView field;


    // Start is called before the first frame update
    void Start()
    {
        lastimeAttack = Time.time;
        field = GetComponent<FieldOfView>();
    }

    


    // si il peut ré attaquer en fonction de l'attack speed
    private bool canAttack() {
        return Time.time - lastimeAttack > attackspeed;
    }

    private void Update() {
        if(Input.GetButtonDown("Attack") && canAttack()){
            lastimeAttack = Time.time;
            List<Transform> objs = field.getListVisible();

            for(int i=0; i<objs.Count; i++){
                if(objs[i].gameObject.CompareTag("Enemy")){
                    Health _health;
                    if(objs[i].gameObject.TryGetComponent<Health>(out _health)) {
                        if(_health.isAlive()){
                            _health.getHit(damageDeal);
                        }
                    }
                }
            }
        }
    }


}
