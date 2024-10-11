using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    void Update()
    {
        //匀速运动小技巧
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3( 0.0f,speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3( 0.0f,-speed * Time.deltaTime, 0.0f);
        }
        /*float horizontalInput = 0.0f;
        float verticalInput = 0.0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput = -1.0f;
        }

        // 计算移动向量
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized * speed * Time.deltaTime;

        // 更新物体的位置
        transform.Translate(movement);
        /*以下是对应的KeyCode枚举值：

        上箭头(Up Arrow)：KeyCode.UpArrow
        下箭头(Down Arrow)：KeyCode.DownArrow
        左箭头(Left Arrow)：KeyCode.LeftArrow
        右箭头(Right Arrow)：KeyCode.RightArrow
        按键状态：
Input.GetKey用于检测按键是否在当前帧持续按下。
Input.GetKeyDown用于检测按键在当前帧是否刚刚按下。
Input.GetKeyUp用于检测按键在当前帧是否刚刚释放。
        */
    }
}
