using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstaclePre;

    //public Vector3 spawnSpot;

    public float xPos;
    
    public float zPos;
    
    public int obstacleAmount;
    
    void Start()
    {
        for (int o = 0; o < obstacleAmount; o++)
        {
            
            Vector3 obstPos = new Vector3(Random.Range(-xPos,xPos), 1, Random.Range(zPos,zPos-4));
            
            Instantiate(obstaclePre, obstPos, transform.rotation);
        }
    }
}
