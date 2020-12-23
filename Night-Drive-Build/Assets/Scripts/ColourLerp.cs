using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourLerp : MonoBehaviour
{
    public Color[] colors;
    
    Color colorStart = Color.white;
    Color colorEnd = Color.black;
    
    float duration = 1.0f;

    public int whichColor;
    
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);

        if (lerp >= 0.99)
        {
            colorSwap();
        }
    }

    public void colorSwap()
    {
        whichColor = Random.Range(0, colors.Length);
        colorStart = colors[whichColor];
        whichColor = Random.Range(0, colors.Length);
        colorEnd = colors[whichColor];
    }
}
