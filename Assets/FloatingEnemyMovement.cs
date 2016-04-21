using UnityEngine;

public class FloatingEnemyMovement : MonoBehaviour {

    public float speed = 3.0F;
    public float floatHeight = 3.0F;
    public GameObject self;

    void Start()
    {
        transform.position = transform.position + new Vector3(0, floatHeight, 0);
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        //if the object you are colliding with has the tag "Finsih"
        //then you will destroy the current gameObject(i.e. the enemy that
        //collided with the obstacle.)
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(self);
        }
    }
}