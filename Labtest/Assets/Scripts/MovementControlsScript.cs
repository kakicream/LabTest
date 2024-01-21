using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlsScript : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void Update()
    {
        Movement();
    }
}