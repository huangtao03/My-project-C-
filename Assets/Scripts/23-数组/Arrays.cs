using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //�������鲢��ֵ���� 1


    //int[] myIntArray = new int[4];
    //void Start()
    //{
    //    myIntArray[0] = 12;
    //    myIntArray[1] = 13;
    //    myIntArray[2] = 14;
    //    myIntArray[3] = 15;
    //}

    //�������鲢��ֵ���� 1


    public GameObject[] players;

    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");//ͨ����ǩPlayer��ȡ����Ϸ���󼯺�

        for (int i = 0;i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + "is named " + players[i].name);
        }
    }
}
