using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public float timer = 0f;
    public float timerGoal = 15f;
    public float timerDisplay;

    public Text timerText;

    public GameObject canvas;
    public GameObject car;

    void Update()
    {
        timer += 1 * Time.deltaTime;
        timerDisplay = (timer / timerGoal) * 100f;
        
        if (timer >= timerGoal)
        {
            timerDone();

            //timer = 0;
        }

        timerText.text = "Loading: " + timerDisplay.ToString(("0.0")) + "%";
    }

    void timerDone()
    {
        canvas.SetActive(false);
        car.SetActive(true);
    }
}
