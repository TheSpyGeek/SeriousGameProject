using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int nbHealthPoint;


    public int currentHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = nbHealthPoint;
    }

  
    public void checkHealth() {
        if(currentHP <= 0) {
            Destroy(gameObject);
        }
    }

    // appelé par la personne qui tape
    public void getHit(int dmg) {
        currentHP -= dmg;
        checkHealth();
    }


}
