using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        //if the object you are colliding with has the tag "Obst"
        //then you will destroy the current gameObject(i.e. the enemy that
        //collided with the obstacle.)
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    }
}
