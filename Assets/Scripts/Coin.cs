using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float RotateSpeed;
  

   
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotateSpeed);
    }
}
