using UnityEngine;

//[ExecuteInEditMode]
public class DebugDeveloperConsoleVisible : MonoBehaviour
{
    private void Awake()
    {
       // Debug.LogWarning("hi");
    }

    private void Start()
    {
       Debug.developerConsoleVisible = true;
       
    }
}
