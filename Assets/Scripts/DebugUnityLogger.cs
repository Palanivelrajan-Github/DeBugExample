using UnityEngine;

[ExecuteInEditMode]
public class DebugUnityLogger : MonoBehaviour
{
    private static readonly ILogger logger = Debug.unityLogger;
    private static readonly string kTAG = "MyGameTag";


    private void Start()
    {
       Debug.ClearDeveloperConsole();
        MyGameMethod();
        
    }


    private void MyGameMethod()
    {
        logger.Log(kTAG, "Hello");

        Debug.unityLogger.Log(kTAG, "World");
        
        
    }
}