using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisScript : MonoBehaviour
{
    public float range;


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float hPos = h * range;
        float vPos = v * range;

        transform.position = new Vector3(hPos, vPos, 0);
        Debug.Log($"Horizontal Position : {hPos}");
        Debug.Log($"Vertical Position : {vPos}");

        
    }
}