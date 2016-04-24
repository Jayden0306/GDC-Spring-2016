using UnityEngine;

public class FloatingEnemyMovement : MonoBehaviour {

    public float speed = 3.0F;
    public float floatHeight = 3.0F;

    void Start()
    {
        transform.position = transform.position + new Vector3(0, floatHeight, 0);
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}