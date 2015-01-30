using UnityEngine;
using System.Collections;

public class Gun_Done : MonoBehaviour {

    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clonedBullet;
            clonedBullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
            clonedBullet.GetComponent<Rigidbody>().AddForce(clonedBullet.transform.forward * 2000);
        }
	}
}
