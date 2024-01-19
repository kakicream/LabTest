using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time : " + Time.deltaTime);
    }
    void Update()
    {
        Debug.LogWarning("Update time : " + Time.deltaTime);
    }
}
