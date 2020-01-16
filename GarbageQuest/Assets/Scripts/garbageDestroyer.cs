using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Type))]

public class garbageDestroyer : MonoBehaviour
{

    private Collider _colllider;
    public Type type;
    public GameObject gameState;

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

                    Type _type;
                    if (other.gameObject.TryGetComponent<Type>(out _type)){
                        
                        if (type.m_type == _type.m_type){
                            // Score s = GameObject.Find("GameState").GetComponent<Score>();
                            gameState.GetComponent<Score>().addScore(10);
                        }else{
                            // Score s = GameObject.Find("GameState").GetComponent<Score>();
                            gameState.GetComponent<Score>().loseScore(10);
                        }

                    }
                    
                    Destroy(other.gameObject);

                }

            }
        }

    }
}
