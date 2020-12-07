using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourStart : MonoBehaviour
{
    public Color32[] colours;

	int col;
	
	Renderer objRend;

	void Start()
    {
        int col = Random.Range(0, colours.Length);
        
        objRend = GetComponent<Renderer>();

        objRend.material.color = colours[col];
    }
}
