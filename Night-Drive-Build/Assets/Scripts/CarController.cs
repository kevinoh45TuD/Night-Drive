using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody sphereRB;

    public float forwardAccel = 8f, reverseAccel = 4f, maxSpeed = 50f, turnStrength = 180f, gravityForce = 10f, dragOnGround = 3f;

    private float speedInput, turnInput;

    private float multiplier = 1000f;

    private bool grounded;

    public LayerMask whatIsGround;

    public float groundRayLength = 0.5f;

    public Transform groundRayPoint;
    
    private void Start()
    {
        sphereRB.transform.parent = null;
    }

    private void Update()
    {
        speedInput = 0f;

        if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel * multiplier;
        }
        
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel * multiplier;
        }

        turnInput = Input.GetAxis("Horizontal");

        if (grounded)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,(turnInput * turnStrength * Time.deltaTime * Input.GetAxis("Vertical")), 0f));
        }
        
        transform.position = sphereRB.transform.position;
    }

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLength, whatIsGround))
        {
            grounded = true;
            
            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }

        if (grounded)
        {
            sphereRB.drag = dragOnGround;

            if (Mathf.Abs(speedInput) > 0)
            {
                sphereRB.AddForce(transform.forward * speedInput);
            }
        }
        else
        {
            sphereRB.drag = 0.1f;
            
            sphereRB.AddForce(Vector3.up * -gravityForce * 100f);
        }
    }
}
