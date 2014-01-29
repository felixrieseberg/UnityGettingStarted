using UnityEngine;
using System.Collections;

public class GunTR : MonoBehaviour {

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject clonedBullet;
			clonedBullet = Instantiate(bulletPrefab,
			                           transform.position,
			                           transform.rotation) as GameObject;
			clonedBullet.rigidbody.AddForce(clonedBullet.transform.forward * 2000);
		}
	}
}
