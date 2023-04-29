using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class FirstPersonMovement : MonoBehaviour
{
    // Player's movement params
    public Vector3 direction;
    public float speed;

    public Rigidbody rb; // Players Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // All physics calculations happen in FixedUpdate
    void FixedUpdate()
    {
        // transform.Translate(direction * speed * Time.deltaTime);
        Vector3 localDirection = transform.TransformDirection(direction);
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
    }

    // OnPlayerMove event handler
    public void OnPlayerMove(InputValue value)
    {
        // A vector with x and y components
        // corresponding to the player's WASD and arrow inputs
        // components are in the range [-1,1]
        Vector2 inputVector = value.Get<Vector2>();

        //move in the XZ-Plane (No Jumping = No Y Plane)
        direction.x = inputVector.x;
        direction.z = inputVector.y;

    }
}
