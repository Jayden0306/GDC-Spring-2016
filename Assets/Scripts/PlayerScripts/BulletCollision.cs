using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

    public AudioClip bulletSound;

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Enemy")
        //{
        AudioSource.PlayClipAtPoint(bulletSound, transform.position, 1000f);
        Destroy(this.gameObject);
        //}
    }
}
