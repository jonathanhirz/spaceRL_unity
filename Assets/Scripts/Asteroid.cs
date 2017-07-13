using UnityEngine;

public class Asteroid : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log("HIT");
		if(coll.gameObject.tag == "beam") {
			Destroy(gameObject);
		}
	}
}
