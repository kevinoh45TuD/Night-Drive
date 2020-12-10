using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    
    public GameObject[] paths;

    public Vector3 reset;

    //public int pathAmount;

    public float shapeSpace;
    
    public float timer = 0.0f; // begins at this value
    
    public float timerMax = 3.0f; // event occurs at this value
    
    public float totalDist, pathAmount, pathSize, pathSpeed, timeTillEnd;
    
    void OnEnable()
    {
        //wait = timeToReach / pathAmount;
        
        /*
         for (int p = 0; p < pathAmount-1; p++)
        {
            Vector3 pos = new Vector3(0, 0, 5f + (p * shapeSpace));
            
            Instantiate(paths[0], pos, transform.rotation);
        } 
        */
        
        totalDist = pathAmount * pathSize;
        timeTillEnd = totalDist / pathSpeed;

        reset.z = pathSize * pathAmount;
    }
    
    private int pathNum;

    void makePath()
    {
        int pathNum = Random.Range(0, paths.Length);
        
        Instantiate(paths[pathNum], reset, transform.rotation);
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        timerMax = pathSize / pathSpeed;
        
        if (timer >= timerMax)
        {
            Debug.Log("timerMax reached !");
            
            timer = 0.0f;
            makePath();
        }
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bound")
        {
            Debug.Log("why");
            
            Spawn();
            
            //Destroy(other.gameObject);
        }
    }

    void Spawn()
    {
        
        Vector3 spawn = new Vector3(0,0, 5f + (shapeSpace * pathAmount));

        
        Instantiate(paths[0], spawn, transform.rotation);
    } */
}
