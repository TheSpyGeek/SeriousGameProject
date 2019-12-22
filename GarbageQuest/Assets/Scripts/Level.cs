using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private bool m_isFinished;

    public GameObject m_enemyList;
    public DoorOpen doorOpen;

    // Start is called before the first frame update
    void Start()
    {
        m_isFinished = false;
        
    }

    public void startLevel (){
        m_enemyList.SetActive(true);
        m_isFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!m_isFinished){
            if(noEnemies()){
                doorOpen.openDoor();
            }
        }
    }

    bool noEnemies() {
        GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
        return array.Length == 0;
    }
}
