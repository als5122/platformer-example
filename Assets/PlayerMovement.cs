using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	CharacterController characterController;
	public float horizontalMovementSpeed = 5f;
	public float gravity = 10f;
	Vector3 movementVector;
	
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
		
	
	}
	
	// Update is called once per frame
	void Update () {
		movementVector.x = Input.GetAxis("Horizontal") * horizontalMovementSpeed;
		movementVector.y = -gravity;
		movementVector.z = 0;
		
		movementVector = movementVector * Time.deltaTime;
		characterController.Move(movementVector);
	
		
	}
}
