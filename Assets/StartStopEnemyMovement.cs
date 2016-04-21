using UnityEngine;

public class StartStopEnemyMovement : MonoBehaviour {

    public float speed = 3f;
    public GameObject self;

    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime * Mathf.PingPong(Time.time - startTime, 0.8F);
    }

    void OnCollisionEnter(Collision collision)
    {
        //if the object you are colliding with has the tag "Obst"
        //then you will destroy the current gameObject(i.e. the enemy that
        //collided with the obstacle.)
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(self);
        }
    }
}
