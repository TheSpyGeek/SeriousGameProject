using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class DoorOpen : MonoBehaviour
{

    private Animation m_animation;
    private bool m_animationStarted;

    public StudioEventEmitter WinEmitter;
    public StudioEventEmitter DoorEmitter;

    private void Start() {
        m_animationStarted = false;
        m_animation = GetComponent<Animation>();
    }



    public void openDoor(){
        m_animation.Play();
        m_animationStarted = true;

        if(WinEmitter != null) {
            WinEmitter.Play();
        }

        if(DoorEmitter != null) {
            DoorEmitter.Play();
        }


}

}
