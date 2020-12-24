using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PathManagerV2 : MonoBehaviour
{
    public GameObject[] pathList;
    public GameObject[] buildingList;

    public float zSpawn;

    public float pathLength;

    public int pathAmount;

    public Transform playerTransform;
    
    private List<GameObject> activePaths = new List<GameObject>();
    private List<GameObject> activeBuildingsLeft = new List<GameObject>();
    private List<GameObject> activeBuildingsRight = new List<GameObject>();

    public float pathWidth;
    

    public void Start()
    {

        for (int i = 0; i < pathAmount; i++)
        {
            if (i == 0)
            {
                SpawnPath(0);
                SpawnBuildings(0);
            }
            else
            {
                SpawnPath(Random.Range(0, pathList.Length));
                SpawnBuildings(Random.Range(0, buildingList.Length));
            }
            
        }
        
    }

    public void Update()
    {
        if (playerTransform.position.z - 35 > zSpawn - (pathAmount * pathLength))
        {
            SpawnPath(Random.Range(0, pathList.Length));
            SpawnBuildings(Random.Range(0, buildingList.Length));
            
            DestroyPath();
        }
    }

    public void SpawnPath(int pathIndex)
    {
        GameObject go = Instantiate(pathList[pathIndex], transform.forward * zSpawn, transform.rotation);
        activePaths.Add(go);
        zSpawn += pathLength;
    }

    public void SpawnBuildings(int buildIndex)
    {
        GameObject goL = Instantiate(buildingList[buildIndex], (transform.forward * zSpawn) + (transform.right * -pathWidth), transform.rotation);
        activeBuildingsLeft.Add(goL);
        GameObject goR = Instantiate(buildingList[buildIndex], (transform.forward * zSpawn) + (transform.right * pathWidth), transform.rotation);
        activeBuildingsRight.Add(goR);
    }

    public void DestroyPath()
    {
        Destroy(activePaths[0]);
        activePaths.RemoveAt(0);
        
        Destroy(activeBuildingsLeft[0]);
        activeBuildingsLeft.RemoveAt(0);
        
        Destroy(activeBuildingsRight[0]);
        activeBuildingsRight.RemoveAt(0);
    }
}
