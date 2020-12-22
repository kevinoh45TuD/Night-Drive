using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PathManagerV2 : MonoBehaviour
{
    public GameObject[] pathList;

    public float zSpawn;

    public float pathLength;

    public int pathAmount;

    public Transform playerTransform;
    
    private List<GameObject> activePaths = new List<GameObject>();

    public void Start()
    {

        for (int i = 0; i < pathAmount; i++)
        {
            if (i == 0)
            {
                SpawnPath(0);
            }
            else
            {
                SpawnPath(Random.Range(0, pathList.Length));
            }
            
        }
        
    }

    public void Update()
    {
        if (playerTransform.position.z - 35 > zSpawn - (pathAmount * pathLength))
        {
            SpawnPath(Random.Range(0, pathList.Length));
            DestroyPath();
        }
    }

    public void SpawnPath(int pathIndex)
    {
        GameObject go = Instantiate(pathList[pathIndex], transform.forward * zSpawn, transform.rotation);
        activePaths.Add(go);
        zSpawn += pathLength;
    }

    public void DestroyPath()
    {
        Destroy(activePaths[0]);
        activePaths.RemoveAt(0);
    }
}
