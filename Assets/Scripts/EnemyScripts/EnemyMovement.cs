using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    
    public float speed = 3f;

    void Start() {
    }

    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
