using UnityEngine;
using System.Collections;

public class Bomb_Done : MonoBehaviour {

    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        GameObject objectHit = collision.collider.gameObject;
        Transform objLocation = objectHit.transform;

        if (objectHit.tag == "Target")
        {
            GameObject explosion;
            explosion = Instantiate(explosionPrefab, objLocation.position, objLocation.rotation) as GameObject;
            objectHit.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
            Destroy(this.gameObject);
        }
    }
}
