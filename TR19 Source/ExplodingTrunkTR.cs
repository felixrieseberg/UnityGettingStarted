using UnityEngine;
using System.Collections;

public class ExplodingTrunkTR : MonoBehaviour {

	public GameObject myExplosions;
	public GameObject myBoxLid;

	void OnCollisionEnter(Collision myCollision) {
		Collider myCollidor = myCollision.collider;
		if (myCollidor.CompareTag("Bullet")) {
			GameObject thisExplosion;
			thisExplosion = Instantiate(myExplosions,
			                            transform.position,
			                            transform.rotation) as GameObject;
			myBoxLid.rigidbody.AddForce(Vector3.up * 800);
		}
	}
}
