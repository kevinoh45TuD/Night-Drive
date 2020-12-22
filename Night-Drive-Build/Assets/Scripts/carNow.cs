using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class carNow : MonoBehaviour
{
    public GameObject[] vehicleObj;

    public int whichVehicle;

    //public GameObject roadParent;

    public GameObject thisCar;

    private void OnEnable()
    {
        Destroy(gameObject);

        whichVehicle = Random.Range(0, vehicleObj.Length);

        thisCar = Instantiate(vehicleObj[whichVehicle], transform.position, transform.rotation, transform.parent);
        
        thisCar.transform.localScale = new Vector3(0.1f, 2f, 0.1f);
    }
}
