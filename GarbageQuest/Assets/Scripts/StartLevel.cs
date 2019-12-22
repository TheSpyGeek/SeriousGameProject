using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public Level level;

    // Start is called before the first frame update
    void Start()
    {
        level.startLevel();
    }

}
