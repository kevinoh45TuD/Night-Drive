using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlocksEnable : MonoBehaviour
{
    public int optionNum;
    

    public GameObject[] blockSet;
    
    void OnEnable()
    {
        
        optionNum = Random.Range(0, blockSet.Length);

        
        blockSet[optionNum].SetActive(true);
        
    }
}
