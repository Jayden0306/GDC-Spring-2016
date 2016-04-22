using UnityEngine;
using System.Collections;

public class BulletForce : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
    }
}
