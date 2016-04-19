using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    
    public float speed = 3f;
    public GameObject self;

    void Start() {
    }

    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision) {
        //if the object you are colliding with has the tag "Obst"
        //then you will destroy the current gameObject(i.e. the enemy that
        //collided with the obstacle.)
        if (collision.gameObject.tag == "Finish") {
            Destroy(self);
        }
    }
}
