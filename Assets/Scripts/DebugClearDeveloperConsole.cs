using UnityEngine;

public class DebugClearDeveloperConsole : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Hi");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.ClearDeveloperConsole();
        }
    }
}
