using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform player;//玩家的Transform组件

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //每帧更新新摄像机的朝向，使其面向玩家
        transform.LookAt(player);
    }
}
