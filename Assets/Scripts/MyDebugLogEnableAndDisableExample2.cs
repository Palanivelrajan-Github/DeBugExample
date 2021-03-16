using UnityEngine;

public class MyDebugLogEnableAndDisableExample2 : MonoBehaviour
{
    private void Awake()
    {
        // FOR permanent player log do it in player settings -> resolution and presentation -> use player log
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = false;
#else
             Debug.unityLogger.logEnabled = false;
#endif
    }

    private void Start()
    {
        Debug.Log("HelloWorld");
    }
}