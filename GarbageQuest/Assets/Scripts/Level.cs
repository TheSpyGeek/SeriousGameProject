using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private bool m_isFinished;

    public GameObject m_enemyList;
    public GameObject doorOpen;


    //private GameObject[] arrayEnemy;

    // Start is called before the first frame update
    void Start()
    {
        m_isFinished = false;

    }

    public void startLevel (){
        m_enemyList.SetActive(true);
        m_isFinished = false;
        doorOpen.SetActive(true);
        //arrayEnemy = m_enemyList.transform.getChi
    }

    // Update is called once per frame
    void Update()
    {
        if(!m_isFinished){
            if(noEnemies()) {
                if(doorOpen.activeInHierarchy) {
                    doorOpen.GetComponent<DoorOpen>().openDoor();
                    m_isFinished = true;
                }
            }
        }
    }

    bool noEnemies() {
        GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
        return array.Length == 0;
    }
}
