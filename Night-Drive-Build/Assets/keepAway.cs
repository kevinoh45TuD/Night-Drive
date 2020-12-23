using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepAway : MonoBehaviour
{

    public Transform playerTransform;
    public float distanceStart;
    
    void Update()
    {
        gameObject.transform.position = new Vector3(0, 150, playerTransform.position.z + distanceStart);    
    }
}
