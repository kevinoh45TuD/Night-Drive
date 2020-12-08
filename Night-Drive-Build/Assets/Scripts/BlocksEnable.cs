using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlocksEnable : MonoBehaviour
{
    public int optionNum;
    
    public GameObject[] blockSet1;
    public GameObject[] blockSet2;
    public GameObject[] blockSet3;
    public GameObject[] blockSet4;

    void OnEnable()
    {
        optionNum = Random.Range(1, 4);
        
        if (optionNum == 1)
        {
            for (int i = 0; i < blockSet1.Length; i++)
            {
                blockSet1[i].SetActive(true);
            }
        }
        else if (optionNum == 2)
        {
            for (int i = 0; i < blockSet2.Length; i++)
            {
                blockSet2[i].SetActive(true);
            }
        }
        else if (optionNum == 3)
        {
            for (int i = 0; i < blockSet3.Length; i++)
            {
                blockSet3[i].SetActive(true);
            }
        }
        else if (optionNum == 4)
        {
            for (int i = 0; i < blockSet4.Length; i++)
            {
                blockSet4[i].SetActive(true);
            }
        }
    }
}
