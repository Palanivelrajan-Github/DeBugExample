using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DebugLogAssertion : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.LogAssertion("hi" );
        Debug.LogAssertion("This is a simple ASSERTION message, with context", transform);
    }
}
