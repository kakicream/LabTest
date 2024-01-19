using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject scapegoat;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(scapegoat);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(scapegoat.GetComponent<MeshRenderer>());
        }
    }
}
