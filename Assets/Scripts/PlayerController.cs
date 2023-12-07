using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45.0f;
    //Input
    private float horizontalInput;
    private float forwardInput;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the car forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        // Roates the car based on horizontal input
        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
    }
}
