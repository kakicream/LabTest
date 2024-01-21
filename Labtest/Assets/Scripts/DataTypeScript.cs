using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    void Start()
    {
        Vector3 Pos = transform.position;
        Pos = new Vector3(0, 2, 0);

        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
