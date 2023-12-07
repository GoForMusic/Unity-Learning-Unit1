using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsMove : MonoBehaviour
{
    private float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        //Move the car forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
