using UnityEngine;

public class DebugDrawRay : MonoBehaviour
{
    // Frame update example: Draws a 10 meter long green line from the position for 1 frame.
    //Example 1
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
    }
    
    
    
    //Example 2
    // Event callback example: Debug-draw all contact points and normals for 2 seconds.
    //Both Collider trigger should be off
    private void OnCollisionEnter(Collision collision)
    {
        Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.magenta, 4, false);
    }
}
