public static class MyDebugLogEnableAndDisableExample1 {

   // [Conditional("ENABLE_LOGS")]

    public static void Debug(string logMsg) {

        UnityEngine.Debug.Log(logMsg);

    }

}
