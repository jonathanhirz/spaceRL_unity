using UnityEngine;

public class ScrollStars : MonoBehaviour {

	public float scroll_speed = 0.5f;
	public GameObject ship;

	Material _material;
	Vector3 offset;

	// Use this for initialization
	void Start() {
		_material = GetComponent<Renderer>().material;
		offset = transform.position - ship.transform.position;
	}
	
	// Update is called once per frame
	void Update() {
		_material.mainTextureOffset = new Vector2(ship.transform.position.x * scroll_speed, ship.transform.position.y * scroll_speed);
		transform.position = ship.transform.position + offset;
	}
}