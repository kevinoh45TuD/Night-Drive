using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourStart : MonoBehaviour
{
    public Material[] colours;

	private int col;

	void Start()
    {
        int col = Random.Range(0, colours.Length);
        
        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
        mesh.material = colours[col];
	}
}
