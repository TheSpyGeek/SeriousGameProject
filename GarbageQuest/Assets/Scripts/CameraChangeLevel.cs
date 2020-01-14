using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class CameraChangeLevel : MonoBehaviour
{

    public Level m_nextLevel;
    public StudioEventEmitter m_emitter;
    public float musicChange;


    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            GameObject obj = Camera.main.gameObject;
            smoothTransformMove smooth = obj.GetComponent<smoothTransformMove>();
            m_emitter.SetParameter("Type Combat", musicChange);
            //m_emitter.gameObject.SetActive(false);
            if(smooth != null) {
                Transform m_nextLevelTransform = m_nextLevel.gameObject.transform;
                smooth.endMarker = m_nextLevelTransform;
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                if(player != null) {
                    player.transform.position = new Vector3(m_nextLevelTransform.position.x, m_nextLevelTransform.position.y + 0.1f, m_nextLevelTransform.position.z);
                }
                m_nextLevel.startLevel();
            }
        }
    }
}
