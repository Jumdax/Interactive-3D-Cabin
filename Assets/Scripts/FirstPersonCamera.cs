using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    // Camera attached to the Player
    public Camera playerCamera;

    // Container variable for the mouse delta valuess each frame
    public float deltaX;
    public float deltaY;

    //Container variables for the player's rotation around the X and Y axis
    public float xRot; // rotation around the x-axis in degrees
    public float yRot; // rotation around the y-axis in degrees

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main; // set player camera
        Cursor.visible = false;  // hide the cursor
    }

    // Update is called once per frame
    void Update()
    {
        // Keep track of the player's x and y rotation
        yRot += deltaX;
        xRot -= deltaY;

        // Keep the player's x rotation clamped to [-90,90] degrees
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        // rotate the camera around the x-axis
        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRot, 0);
    }

    // OnCamera event handler
    public void OnCameraLook(InputValue value)
    {
        // Reading the mouse deltas as a vector 2
        // (deltaX is the x componenet and deltaY is the y componenet)
        Vector2 inputVector = value.Get<Vector2>();
        deltaX = inputVector.x;
        deltaY = inputVector.y;
    }

}
