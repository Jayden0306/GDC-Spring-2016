using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Enemy")
        //{
        Destroy(this.gameObject);
        //}
    }
}
