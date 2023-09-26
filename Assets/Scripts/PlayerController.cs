using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Camera mainCamera;
    public Camera povCamera;
    public KeyCode switchKey;

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // Receive Player input
        horizontalInput = Input.GetAxis("Horizontal" + inputId);
        forwardInput = Input.GetAxis("Vertical" + inputId);

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey) && (inputId == "1"))
        {
            mainCamera.enabled = !mainCamera.enabled;
            povCamera.enabled = !povCamera.enabled;
        }
    }
}
