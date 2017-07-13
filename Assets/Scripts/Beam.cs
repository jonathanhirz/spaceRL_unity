using UnityEngine;

public class Beam : MonoBehaviour {

	public float velocity;

	GameObject gun;

	void Start() {
		gun = GameObject.Find("gun");
	}

	void Update() {
		transform.Translate(Vector2.up * velocity);
	}

	void OnBecameInvisible() {
		ResetBeam();
	}

	void ResetBeam() {
		gameObject.SetActive(false);
		if(gun != null) {
			transform.position = gun.transform.parent.gameObject.transform.position;
		}
	}
}