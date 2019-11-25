using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0.2f;

    private Quaternion rota;

    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start(){
        _rb = GetComponent<Rigidbody>();
        rota = new Quaternion();
    }

    // Update is called once per frame
    void Update(){

        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");
        move.y = Input.GetAxis ("Vertical");

        updateRotationFromMove(move);
        

        Vector3 position = transform.position;
        position.x += move.x*speed;
        position.z += move.y*speed;



        transform.position = position;
    }

    // rotation de l'objet par rapport à l'input
    // pour avoir le vector forward toujours devant
    private void updateRotationFromMove(Vector2 move) {
        if(move.x < 0) { // vers la gauche
            rota.eulerAngles = new Vector3(0, -90, 0);
        }
        if(move.x > 0) { // vers la droite
            rota.eulerAngles = new Vector3(0, 90, 0);
        }
        if(move.y > 0) { // vers le haut
            rota.eulerAngles = new Vector3(0, 0, 0);
        }
        if(move.y < 0) { // vers le bas
            rota.eulerAngles = new Vector3(0, 180, 0);
        }
        transform.rotation = rota;
    }

    private void OnDrawGizmos() {
      
        
        Gizmos.DrawLine(transform.position, transform.position + transform.forward*1.0f);
    }

}
