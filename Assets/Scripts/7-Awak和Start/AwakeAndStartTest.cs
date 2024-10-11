using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStartTest : MonoBehaviour
{

    private void Start()
    {
        GameObject go = new GameObject("New Obj");
        go.AddComponent <AwakeAndStart>().Test();
    }
}
