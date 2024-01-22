using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardinalDirection : MonoBehaviour
{
    enum Direction { North, East, South, West }; // North 0, East 1, South 2, West 3
                                                 // First value is 0 as default
                                                 // Custom assignment possible
                                                 // Using colon(:), we can assign the data type

    [SerializeField]
    private Direction myDirection;

    void Start()
    {
        if (ReverseDirection(myDirection) == Direction.East)
        {
            Debug.Log("East");
        }
        else
        {
            Debug.Log("Where are you going?");
        }
    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
        {
            dir = Direction.South;
        }
        else if (dir == Direction.South)
        {
            dir = Direction.North;
        }
        else if (dir == Direction.East)
        {
            dir = Direction.West;
        }
        else if (dir == Direction.West)
        {
            dir = Direction.East;
        }
        return dir;
    }
}
