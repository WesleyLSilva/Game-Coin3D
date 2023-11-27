using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;
    
    
    private void FixedUpdate()
    {
        transform.LookAt(Target);
    }
}
