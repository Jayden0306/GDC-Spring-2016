using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

    public int enemyScore = 10;
	public GameObject myExplosion;

    void OnCollisionEnter(Collision collision)
    {
        //if the object you are colliding with has the tag "Obst"
        //then you will destroy the current gameObject(i.e. the enemy that
        //collided with the obstacle.)
        if (collision.gameObject.tag == "Bullet")
        {
			GameObject newExplosion = (GameObject)Instantiate (myExplosion, transform.position, transform.rotation);
			Destroy (newExplosion, 0.3f);
            ScoreManager.score += enemyScore;
            ScoreManager.enemyCount--;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            ScoreManager.enemyCount--;
            Destroy(this.gameObject);
        }
    }
}
