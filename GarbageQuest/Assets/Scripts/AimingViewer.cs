using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingViewer : MonoBehaviour
{
    // Start is called before the first frame update
    public float aimingLength = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        RaycastHit hit;
        Gizmos.color = Color.red;
        float remainingLength = aimingLength;
        Vector3 currentLineStart = transform.position;
        Vector3 currentLineDir = transform.forward;

        do 
        {
            if (Physics.Raycast(currentLineStart, currentLineDir, out hit, remainingLength))
            {
                float distanceToPoint = Vector3.Distance(currentLineStart, hit.point);
                
                Gizmos.DrawRay(currentLineStart, currentLineDir * distanceToPoint);
                
                remainingLength -= distanceToPoint;
                currentLineStart = hit.point;
                currentLineDir = Vector3.Reflect(currentLineDir, hit.normal);
            }
            else
            {
                Gizmos.DrawRay(currentLineStart, currentLineDir * remainingLength);
                remainingLength = 0;
            }
        }
        while(remainingLength > 0);

    }
}
