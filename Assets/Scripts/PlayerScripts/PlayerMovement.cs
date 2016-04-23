using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    //Lane size
    public float speed;
    public float spacesToTheLeft;
    public float spacesToTheRight;
    public float laneWidth;

    
    //Player movement
    private CharacterController controller;
    private int position;
    private float startZ;

    void Awake() {
        controller = GetComponent<CharacterController>();
        position = 0;
        startZ = transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        //controller.SimpleMove(new Vector3(0, 0, Input.GetAxis("Vertical")) * speed);

        if (Input.GetKeyDown(KeyCode.W) && position < spacesToTheLeft)
        {
            position++;
        }

        if (Input.GetKeyDown(KeyCode.S) && -position < spacesToTheRight)
        {
            position--;
        }

        float goal = startZ + position * laneWidth;
        float direction = goal - transform.position.z;
        direction = Mathf.Clamp(direction, -1, 1);

        controller.Move(new Vector3(0, 0, direction) * speed * Time.deltaTime);
    }

}
