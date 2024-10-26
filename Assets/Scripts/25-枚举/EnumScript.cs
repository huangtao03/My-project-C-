using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    //enum Direction { North,East,South,West};
    //// Start is called before the first frame update
    //void Start()
    //{
    //    Direction myDirection;
    //    myDirection = Direction.North;
    //}

    //Direction ReverseDirection (Direction dir)
    //{
    //    if (dir == Direction.North)
    //    {
    //        dir = Direction.South;
    //    }
    //    else if(dir == Direction.South) { dir = Direction.North;}
    //    else if (dir == Direction.East) { dir = Direction.West; }
    //    else if (dir == Direction.West) { dir = Direction.East;}
    //    return dir;
    //}


    enum Direction { North, East, South, West };

    // Start is called before the first frame update
    void Start()
    {
        Direction myDirection = Direction.North;
        Debug.Log("Initial direction: " + myDirection);
        myDirection = ReverseDirection(myDirection);
        Debug.Log("Reversed direction: " + myDirection);
    }

    Direction ReverseDirection(Direction dir)
    {
        switch (dir)
        {
            case Direction.North:
                return Direction.South;
            case Direction.South:
                return Direction.North;
            case Direction.East:
                return Direction.West;
            case Direction.West:
                return Direction.East;
            default:
                // 如果方向不在枚举中，返回原来的值可能是合适的。
                return dir;
        }
    }
}

