using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPath : MonoBehaviour
{

    public Vector3 end;
    
    void Update()
    {
        if (this.transform.position == end)
        {
            
            Destroy(gameObject);
        }
    }
}
