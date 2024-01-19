
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CubeMover : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Start()
    {
        Debug.Log(transform.position.x);
        if (transform.position.y < 5.0f)
        {
            Debug.Log("Hit Ground");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        coffeeTemperature -= Time.deltaTime * 5.0f;
    }

    void TemperatureTest()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold");
        }
        else
        {
            print("Coffee is just right");
        }
    }
}
