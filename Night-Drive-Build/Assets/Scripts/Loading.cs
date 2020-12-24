using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject player;

    public Text distance;

    public float moveAmount;

    public bool Thunder;
    public GameObject Thor;

    void Update()
    {
        moveAmount = (player.transform.position.z) / 100f;
        distance.text = "Distance Travelled: " + moveAmount.ToString(("0.0")) + "Km";

        if (Thunder)
        {
            Thor.SetActive(true);
        }
        else if (!Thunder)
        {
            Thor.SetActive(false);
        }
    }

}
