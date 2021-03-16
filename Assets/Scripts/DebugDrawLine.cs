using UnityEngine;

public class DebugDrawLine : MonoBehaviour
{
    private float _q;

    private void Start()
    {
        // draw a 5-unit white line from the origin for 2.5 seconds
        Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white, 2.5f);
    }

    private void FixedUpdate()
    {
        // always draw a 5-unit different colored line from the origin
        var color = new Color(_q, _q, 1.0f);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 5, 0), color);
        _q += 0.01f;

        if (_q > 1.0f) _q = 0.0f;
    }
}