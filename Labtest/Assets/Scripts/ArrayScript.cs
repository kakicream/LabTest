using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    int[] myIntArray = new int[5];
    [SerializeField]    int sum;

    public int[] myIntArray2 = { 12, 345, 76, 56, 899 };

    public GameObject[] players;

    void Start()
    {
        myIntArray[0] = 12; myIntArray[1] = 14; myIntArray[2] = 152; myIntArray[3] = 1; myIntArray[4] = 123;

        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log($"Name : {players[i].name}");
        }

        
        foreach(var element in myIntArray)
        {
            sum += element;
        }

        foreach(var player in players)
        {
            Debug.Log($"Name : {player.name} by foreach");
        }
    }
}
