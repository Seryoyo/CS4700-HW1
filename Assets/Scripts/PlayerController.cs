using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    private float speed = 40.0f;
    private float turnSpeed = 90.0f;
    private float horizontalInput;
    private float forwardInput;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
