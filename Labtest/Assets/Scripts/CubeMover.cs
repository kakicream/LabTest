using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
        if (transform.position.x >= 5.0f)
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
    }
}
