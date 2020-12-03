using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentThis : MonoBehaviour
{
    Transform Parent;

    public string parentName;
    
    void Start()
    {
        GameObject go = GameObject.Find(parentName);

        Parent = go.transform;
        
        this.transform.SetParent(Parent);
    }
}
