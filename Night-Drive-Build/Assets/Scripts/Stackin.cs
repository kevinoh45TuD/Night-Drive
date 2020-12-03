using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stackin : MonoBehaviour
{
    public int stackChance;

    public GameObject self;

    public float heightCube;
    
    void Start()
    {
        int stackChance = Random.Range(0, 100);

        if (stackChance >= 50)
        {
            Vector3 pos = new Vector3(0, heightCube, 0);
            Instantiate(self, transform.position+pos, transform.rotation);
        }
    }
}
