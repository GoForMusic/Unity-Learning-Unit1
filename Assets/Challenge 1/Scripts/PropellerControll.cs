using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerControll : MonoBehaviour
{
    public float PropellerSpeed = 500f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward*Time.deltaTime*PropellerSpeed);
    }
}
