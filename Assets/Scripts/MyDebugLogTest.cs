using UnityEngine;

[ExecuteInEditMode]
public class MyDebugLogTest : MonoBehaviour
{
    private void OnEnable()
    {
        //enable and disable logs using MyDebugLogEnableAndDisableOnly static class
        MyDebugLogEnableAndDisableExample1.Debug("Hi");
    }
}
    