using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class carNow : MonoBehaviour
{
    public GameObject[] vehicleObj;
    public GameObject[] buildingObj;

    public int whichVehicle;

    //public GameObject roadParent;

    public GameObject thisCar;
    
    private Vector3 currentEulerAngles;
    private Quaternion currentRotation;

    public float dropAmount;

    public bool isBuilding;

    private void OnEnable()
    {
        currentEulerAngles += new Vector3(0, 180, 0);
        
        currentRotation.eulerAngles = currentEulerAngles;
        
        Destroy(gameObject);

        whichVehicle = Random.Range(0, vehicleObj.Length);

        /*
        if (whichVehicle <= 9)
        {
            thisCar = Instantiate(vehicleObj[0], transform.position, transform.rotation, transform.parent);
        }
        else if (whichVehicle >= 10)
        {
            thisCar = Instantiate(vehicleObj[1], transform.position, transform.rotation, transform.parent);
        }
        */
        
        if (!isBuilding)
        {
            thisCar = Instantiate(vehicleObj[whichVehicle], transform.position, transform.rotation, transform.parent);
        }
        else
        {
            thisCar = Instantiate(buildingObj[whichVehicle], transform.position, transform.rotation, transform.parent);
        }
        
        
        thisCar.transform.rotation =  currentRotation;
        thisCar.transform.position -= new Vector3(0,dropAmount,0);
        if (!isBuilding)
        {
            if (whichVehicle <= 5)
            {
                thisCar.transform.localScale = new Vector3(0.05f, 2f, 0.05f); 
            }
            else if (whichVehicle == 6)
            {
                thisCar.transform.localScale = new Vector3(0.1f, 2f, 0.2f);
                thisCar.transform.position += new Vector3(0,3f,0);
            }
        }
        else
        {
            if (whichVehicle <= 5)
            {
                thisCar.transform.localScale = new Vector3(0.05f, 1f, 0.05f);
            }
            else if (whichVehicle == 6)
            {
                thisCar.transform.localScale = new Vector3(0.1f, 2f, 0.2f);
                thisCar.transform.position += new Vector3(0,3f,0);
            }
        }
    }
}
