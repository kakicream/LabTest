using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }
}
