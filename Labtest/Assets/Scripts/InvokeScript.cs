using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InvokeScript : MonoBehaviour
{
    public GameObject invokeOnce;
    public GameObject invokeRepeat;

    void Start()
    {
        Invoke("InvokeOnce", 2);

        InvokeRepeating("InvokeRepeat", 2, 1);
    }

    void InvokeOnce()
    {
        Instantiate(invokeOnce, new UnityEngine.Vector3(0, 2, 0), Quaternion.identity);
    }

    void InvokeRepeat()
    {
        float x = Random.Range(-2f, 2f);
        float z = Random.Range(-2f, 2f);
        Instantiate(invokeRepeat, new UnityEngine.Vector3(x, 2, z), Quaternion.identity);
    }
}
