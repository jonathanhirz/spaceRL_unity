using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	// get angle of ship, instantiate (or get from pool) a projectile, and let it fly

	public GameObject beam;
	public int number_of_beams = 20;

	float shot_angle;
	List<GameObject> beams = new List<GameObject>();
	int which_shot_fired = 0;

	void Awake() {
		for(int i = 0; i < number_of_beams; i++) {
			beams.Add(Instantiate(beam, transform.position, transform.rotation));
			beams[i].SetActive(false);
		}
	}

	void Update() {
		shot_angle = transform.parent.gameObject.transform.rotation.eulerAngles.z;
		if(Input.GetButtonDown("Jump")) {
			beams[which_shot_fired].transform.position = gameObject.transform.parent.transform.position;
			beams[which_shot_fired].transform.eulerAngles = new Vector3(0, 0, shot_angle);
			beams[which_shot_fired].SetActive(true);
			which_shot_fired++;
			if(which_shot_fired > number_of_beams - 1) {
				which_shot_fired = 0;
			}
		}
	}
}