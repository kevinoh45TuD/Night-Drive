using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0.0f; // begins at this value
    
    public float timerMax = 3.0f; // event occurs at this value

    public Text timerText;
  
    void Update()
    {
        timer += Time.deltaTime;
      
        timerText.text = "Time: " + timer.ToString("0.00");
     
        if (timer >= timerMax)
        {
            Debug.Log("timerMax reached !");
            
            timer = 0.0f;
        }
    }
}
