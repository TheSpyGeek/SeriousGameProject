using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int nbHealthPoint;

    private bool alive;

    public float timeToRespawn;


    private int currentHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = nbHealthPoint;
        alive = true;
    }

  
    public void checkHealth() {
        if(currentHP <= 0) {
            currentHP = 0;
            alive = false;
        }
    }

    // appelé par la personne qui tape
    public void getHit(int dmg) {
        currentHP -= dmg;
        checkHealth();
    }

    public int getCurrentHealth() {
        return currentHP;
    }

    public bool isAlive() {
        return alive;
    }

}
