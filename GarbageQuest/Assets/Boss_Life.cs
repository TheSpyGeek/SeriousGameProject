using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Life : MonoBehaviour
{
    public Health _health;

    public List<GameObject> childsPrefabs;
    public float radius = 2f;

    // Update is called once per frame
    void Update()
    {
        if( ! _health.isAlive()) {

            // Spawning parts independently

            for (int i = 0; i < childsPrefabs.Count; i++)
            {
                float angle = i * Mathf.PI * 2 / childsPrefabs.Count;

                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;
                Vector3 pos = transform.position + new Vector3(x, 0, z);
                
                Instantiate(childsPrefabs[i], pos, childsPrefabs[i].transform.rotation);
            }

            // Lastly destroy itself
            Destroy(gameObject);
        }
    }
}
