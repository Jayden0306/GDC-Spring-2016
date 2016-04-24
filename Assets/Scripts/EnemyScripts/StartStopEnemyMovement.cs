using UnityEngine;

public class StartStopEnemyMovement : MonoBehaviour {

    public float speed = 3f;

    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime * Mathf.PingPong(Time.time - startTime, 0.8F);
    }
}
