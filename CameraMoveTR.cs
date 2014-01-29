using UnityEngine;
using System.Collections;

public class CameraMoveTR : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward * Time.deltaTime);
		} else if (Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector3.forward * Time.deltaTime * -1);
		}
	}
}
