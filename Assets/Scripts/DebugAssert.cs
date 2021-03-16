using UnityEngine;

[ExecuteInEditMode]
public class DebugAssert : MonoBehaviour
{
    public string[] namestr;

    public int number;

    private void OnEnable()
    {
        //if condition false 
        Debug.Assert(number>1,namestr[0]);
        
    }
    
   
    
}