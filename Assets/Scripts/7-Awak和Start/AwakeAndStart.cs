using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    public string myName;
    private void Awake()
    {
        Debug.Log("AwakeAndStart Awake");
    }

    private void Start()
    {
        Debug.Log("AwakeAndStart Start");
        myName = "john";
    }

    public void Test()
    {
        Debug.Log("AwakeAndStart Test");
        Debug.Log(myName);
    }
}
