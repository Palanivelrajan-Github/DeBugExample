using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogAssertionFormat : MonoBehaviour
{


    private int[] num = {1, 2, 3, 4, 5, 6, 7,};
    
    void Start()
    {
    Debug.LogAssertionFormat("hello world");
   // UseParams1(1, 2, 3, 4, 5);
  //  UseParams2(1, "e", gameObject);
    }

    public static void UseParams1(params int[] list)
    {
        foreach (var t in list)
        {
            Debug.Log(t + " ");
        }
    }
    
    public static void UseParams2(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Debug.Log(list[i] + " ");
        }
    }
    
}
