using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlocksEnable : MonoBehaviour
{
    public int optionNum;
    public int optionAmount;

    public GameObject[] blockSet;
    
    void OnEnable()
    {
        optionAmount = Random.Range(0, 3);
        optionNum = Random.Range(0, blockSet.Length);

        for (int i = 0; i < optionAmount; i++)
        {
            blockSet[optionNum].SetActive(true);
        }
    }
}
