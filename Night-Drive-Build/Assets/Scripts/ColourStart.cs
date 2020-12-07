using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourStart : MonoBehaviour
{
    public Color32[] colours;

	private int col;

	void Start()
    {
        int col = Random.Range(0, colours.Length);
        
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        //mesh.colors = colours[col];
	}
}
