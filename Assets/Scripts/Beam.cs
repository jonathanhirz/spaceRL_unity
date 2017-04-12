using UnityEngine;

public class Beam : MonoBehaviour {

	public float velocity;

	GameObject gun;
	Rigidbody2D rb2d;

	void Start() {
		gun = GameObject.Find("gun");
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Update() {
		rb2d.AddForce(transform.up * velocity);
	}

	void OnBecameInvisible() {
		ResetBeam();
	}

	void ResetBeam() {
		gameObject.SetActive(false);
		rb2d.velocity = Vector2.zero;
		rb2d.angularVelocity = 0;
		if(gun != null) {
			transform.position = gun.transform.parent.gameObject.transform.position;
		}
	}
}