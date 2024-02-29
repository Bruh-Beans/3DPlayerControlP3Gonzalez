using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on verticle input
        transform. Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey)) 
        { mainCamera.enabled = !mainCamera.enabled;
          hoodCamera.enabled = !hoodCamera.enabled; 
        }

    }
}
