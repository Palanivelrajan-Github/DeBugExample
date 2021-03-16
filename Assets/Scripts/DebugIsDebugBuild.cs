using UnityEngine;

//Development build for testing with debug.log
public class DebugIsDebugBuild : MonoBehaviour
{
    private void Start()
    {
        //this way you can easily deploy beta builds with debug prints and final builds without. 
        // Log some debug information only if this is a debug build.
        if (Debug.isDebugBuild)
            Debug.Log("This is Developer Build");
        
    }
}