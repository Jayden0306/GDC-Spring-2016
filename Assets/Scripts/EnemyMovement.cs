using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Transform destination;
    public float speed = 3f;
    private Vector3 untoeth;
    public GameObject enemy;

    void Start()
    {
        untoeth = destination.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, untoeth, Time.deltaTime * speed);

        //This code kind of works. If the line above doesn't work then we will try to use this.
        //Note: frometh is just the this object's transform.position
        //Note: be sure to include    using System.Collections; at the very top.
        /* transform.position = Vector3.Lerp(frometh, untoeth,
          Mathf.SmoothStep(0f, 1f,
           Mathf.PingPong(Time.time / speed, 1f)));*/
    }

    void OnCollisionEnter(Collision collision)
    {
        //if the object you are colliding with has the tag "Obst"
        //then you will destroy the current gameObject(i.e. the enemy that
        //collided with the obstacle.)
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(enemy);
        }
    }
}
