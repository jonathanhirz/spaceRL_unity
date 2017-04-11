using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {

	public float speed;

	Rigidbody2D rb2d;

	// Use this for initialization
	void Start() {
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveH, moveV);
		rb2d.AddForce(speed * movement);

		float ship_rot = Mathf.Atan2(rb2d.velocity.y, rb2d.velocity.x) * 180/Mathf.PI - 90;
		if(Mathf.Abs(rb2d.velocity.x) > 0 || Mathf.Abs(rb2d.velocity.y) > 0) {
			transform.localEulerAngles = new Vector3(0, 0, ship_rot);
		}
	}
	
	// Update is called once per frame
	void Update() {
		
	}
}
