using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[DefaultExecutionOrder(100)]
//调用脚本顺序（数字小先调用）
public class CheckStade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myObject;
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
