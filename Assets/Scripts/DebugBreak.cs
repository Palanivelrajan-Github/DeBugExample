using System;
using UnityEngine;

public class DebugBreak : MonoBehaviour
{


    // Update is called once per frame
    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Break();
        }

       
        transform.Rotate(1.0f, 0f, 0f, Space.World);
    }
    
    
}