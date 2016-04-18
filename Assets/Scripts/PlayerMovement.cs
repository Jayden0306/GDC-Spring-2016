using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Vector3 moveDirection = Vector3.zero;
    private float gravity = 20.0f;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = GetComponent<CharacterController>();
        /*if(Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(0, 0, speed);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(0, 0, -speed);
        }*/
      
            moveDirection = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
