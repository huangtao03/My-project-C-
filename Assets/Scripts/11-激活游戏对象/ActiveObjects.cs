using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[DefaultExecutionOrder(500)]
//调用脚本顺序（数字小先调用）
public class ActiveObjects : MonoBehaviour
{
    //private void Awake()
    //{
    //    gameObject.SetActive(false);
    //}
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
