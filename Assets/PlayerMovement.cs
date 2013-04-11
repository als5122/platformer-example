using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	CharacterController characterController;
	public float horizontalMovementSpeed = 5f, verticalMovementSpeed = 30f;
	public float gravity = 15f;
	Vector3 movementVector;
	private bool jumping = false;
	
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
		movementVector.y = -gravity;
	
	}
	
	// Update is called once per frame
	void Update () {
		movementVector = new Vector3(Input.GetAxis("Horizontal") * horizontalMovementSpeed, /*Input.GetAxis("Vertical") * verticalMovementSpeed*/ -gravity, 0); 
		/*if (Input.GetAxis("Vertical") == 0)
		{
			movementVector.y = -25f;
		}*/
		
		if (Input.GetButtonDown("Jump"))
		{
			StartCoroutine("Jump");
		}
		
		if (jumping)
		{
			movementVector.y = 15;
		}
		
		
		movementVector = movementVector * Time.deltaTime;
		characterController.Move(movementVector);
		
		
		
	}
	
	IEnumerator Jump()
	{
		jumping=true;
		yield return new WaitForSeconds(0.15f);
		jumping = false;
	}
}
