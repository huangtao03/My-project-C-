using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //创建数组并赋值方法 1


    //int[] myIntArray = new int[4];
    //void Start()
    //{
    //    myIntArray[0] = 12;
    //    myIntArray[1] = 13;
    //    myIntArray[2] = 14;
    //    myIntArray[3] = 15;
    //}

    //创建数组并赋值方法 1


    public GameObject[] players;

    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");//通过标签Player获取到游戏对象集合

        for (int i = 0;i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + "is named " + players[i].name);
        }
    }
}
