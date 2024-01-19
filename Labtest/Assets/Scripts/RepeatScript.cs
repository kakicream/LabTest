using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatScript : MonoBehaviour
{
    int cupsInTheSink = 4;

    int numEnemies = 3;
    void Start()
    {   
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }

        bool shouldContinue = false;
        do
        {
            print("Hello World");
        }
        while (shouldContinue == true);

        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }

        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach(string item in strings)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
