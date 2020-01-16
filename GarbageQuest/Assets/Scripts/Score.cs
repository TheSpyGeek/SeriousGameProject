using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

private Score m_Instance;
public Score Instance { get { return m_Instance; } }
    int score = 0;

    void Awake(){
        m_Instance = this;
        Debug.Log("Score : " + score);
    }

    void OnDestroy(){
        m_Instance = null;
        Debug.Log("Score : " + score);
    }

    public void addScore(int value){
        score += value;
        Debug.Log("Score : " + score);
    }

    public void loseScore(int value){
        score -= value;
        Debug.Log("Score : " + score);
    }

    public int getScore(){
        return score;
    }
    
}
