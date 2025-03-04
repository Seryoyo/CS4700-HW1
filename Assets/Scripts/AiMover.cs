using UnityEngine;

public class AiMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private float speed = 20.0f;



    // Update is called once per frame
    void Update()
    {

        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Rotates the car based on horizontal input
    }
}
