using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_rotation : MonoBehaviour {
	public int speed, tilt;
	public Vector3 target;

	void Update() {
		transform.Rotate (Vector3.up * tilt); 
		transform.Rotate (Vector3.left * speed);
	
	}

}
