using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float moveSpeed = 6;

	Rigidbody m_rigidbody;
	Camera viewCamera;
	Vector3 velocity;

	void Start () {
		m_rigidbody = GetComponent<Rigidbody> ();
		viewCamera = Camera.main;
	}



	void FixedUpdate() {
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
        //m_rigidbody.MovePosition (m_rigidbody.position + velocity * Time.fixedDeltaTime);
        m_rigidbody.velocity = velocity;
        //transform.position = rigidbody.position;
        m_rigidbody.angularVelocity = Vector3.zero;
    }
}