﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoveV2 : MonoBehaviour
{
    public float forwardAmount;
    public int rightAmount;
    public float increaseAmount;
    

    public float timer;
    public float timerMax = 3.0f;

    public Rigidbody playerRB;
    public GameObject zero;

    public float rotateValue;

    void OnEnable()
    {
        
    }

    public void speedIncrease()
    {
        forwardAmount += increaseAmount;
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= timerMax)
        {
            timer = 0.0f;
            speedIncrease();
        }

        transform.position += new Vector3(0,0,forwardAmount);

        if (Input.GetKeyDown(KeyCode.D) && rightAmount < 3)
        {
            rightAmount++;
            
            transform.position += new Vector3(5,0,0 );
        }
        
        if (Input.GetKeyDown(KeyCode.A) && rightAmount > -3)
        {
            rightAmount--;
            
            transform.position -= new Vector3(5,0,0 );
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("hit!");
            
            SceneManager.LoadScene("Game");
        }
    }
}
