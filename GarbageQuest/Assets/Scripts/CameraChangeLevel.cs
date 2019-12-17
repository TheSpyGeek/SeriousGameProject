using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeLevel : MonoBehaviour
{

    public Transform m_nextLevelTransform;


    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            GameObject obj = Camera.main.gameObject;
            smoothTransformMove smooth = obj.GetComponent<smoothTransformMove>();
            if(smooth != null) {
                smooth.endMarker = m_nextLevelTransform;
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                if(player != null) {
                    player.transform.position = new Vector3(m_nextLevelTransform.position.x, m_nextLevelTransform.position.y + 0.1f, m_nextLevelTransform.position.z);
                }
            }
        }
    }
}
