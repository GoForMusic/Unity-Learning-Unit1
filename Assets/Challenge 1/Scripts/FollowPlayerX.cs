using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(25.22f,0,0);
    
    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = plane.transform.position+offset;
    }
}
