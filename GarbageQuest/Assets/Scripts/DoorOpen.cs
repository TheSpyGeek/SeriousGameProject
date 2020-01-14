using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class DoorOpen : MonoBehaviour
{

    private Animation m_animation;
    private bool m_animationStarted;

    private void Start() {
        m_animationStarted = false;
        m_animation = GetComponent<Animation>();
    }



    public void openDoor(){
        m_animation.Play();
        m_animationStarted = true;
        StudioEventEmitter emitter = GetComponent<StudioEventEmitter>();
        if(emitter != null) {
            emitter.Play();
        }

}

}
