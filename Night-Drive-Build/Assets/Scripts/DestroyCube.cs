using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{

    public float end;
    
    void Update()
    {
        if (transform.position.z <= end)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "End")
        {
            Destroy(gameObject);
        }
    }
}
