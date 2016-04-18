using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private CharacterController controller;

    void Awake() {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
       
        controller.SimpleMove(new Vector3(0, 0, Input.GetAxis("Vertical") * speed));
    }
}
