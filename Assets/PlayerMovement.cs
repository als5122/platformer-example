using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	CharacterController characterController;
	public float horizontalMovementSpeed = 5f, verticalMovementSpeed = 30f;
	public float gravity = 10f;
	Vector3 movementVector;
	
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
		movementVector.y = -gravity;
	
	}
	
	// Update is called once per frame
	void Update () {
		movementVector = new Vector3(Input.GetAxis("Horizontal") * horizontalMovementSpeed, Input.GetAxis("Vertical") * verticalMovementSpeed, 0); 
		if (Input.GetAxis("Vertical") == 0)
		{
			movementVector.y = -25;
		}
		
		movementVector = movementVector * Time.deltaTime;
		characterController.Move(movementVector);
	
		
	}
}
