using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlocksEnable : MonoBehaviour
{
    public int optionNum;
    
    public GameObject[] blockSet;

    public int toEnable;
    
    void OnEnable()
    {
        toEnable = Random.Range(0, 101);

        if (toEnable >= 60)
        {
            optionNum = Random.Range(0, blockSet.Length);
        
            blockSet[optionNum].SetActive(true);
        }
    }
}
