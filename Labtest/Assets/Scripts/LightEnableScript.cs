using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnableScript : MonoBehaviour
{

    private Light myLight;
    
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }        
    }
}
