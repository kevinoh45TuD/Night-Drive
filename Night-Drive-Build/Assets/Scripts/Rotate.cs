using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotationSpeed;
    private Vector3 currentEulerAngles;
    private Quaternion currentRotation;

    public float x;
    public float y;
    public float z;

    public bool rotateX;
    public bool rotateY;
    public bool rotateZ;
    
    void Update()
    {
        if (rotateX == true)
        {
            x = 1;
        }
        else if (rotateX == false)
        {
            x = 0;
        }
        
        if (rotateY == true)
        {
            y = 1;
        }
        else if (rotateY == false)
        {
            y = 0;
        }
        
        if (rotateZ == true)
        {
            z = 1;
        }
        else if (rotateZ == false)
        {
            z = 0;
        }
        

        
        
        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;
        
        currentRotation.eulerAngles = currentEulerAngles;
        
        transform.rotation = currentRotation;
        
    }
}
