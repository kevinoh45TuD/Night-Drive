using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float t;
    public Vector3 startPosition;
    public Vector3 target;
    

    public float totalDist, pathAmount, pathSize, pathSpeed, timeTillEnd;
    
    void OnEnable()
    {
        startPosition = transform.position;
        
        totalDist = pathAmount * pathSize;
        timeTillEnd = totalDist / pathSpeed;

        target.z = startPosition.z - totalDist;

    }
    void Update() 
    {
        t += Time.deltaTime/timeTillEnd;
        transform.position = new Vector3(0, 0, (Mathf.Lerp(startPosition.z, target.z, t)));
    }
    public void SetDestination(Vector3 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeTillEnd = time;
        target = destination; 
    }
    
}
