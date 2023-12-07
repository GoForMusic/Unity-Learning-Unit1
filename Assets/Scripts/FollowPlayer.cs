using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 driverOffset = new Vector3(0f,4.45f,-0.4f);
    
    private void LateUpdate()
    {
        
        if (Input.GetKey("x"))
        {
            transform.position = player.transform.position+driverOffset;
        }
        else
        {
            transform.position = player.transform.position+offset;
        }
    }
}
