using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    

    private Animation m_animation;
    private bool m_animationStarted;

    private void Start() {
        m_animationStarted = false;
        m_animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update(){
        if(!m_animationStarted) {
            if(noEnemies()) {
                m_animation.Play();
                m_animationStarted = true;
                Debug.Log("Start");
            }
        }
    }

    bool noEnemies() {
        GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
        return array.Length == 0;
    }
}
