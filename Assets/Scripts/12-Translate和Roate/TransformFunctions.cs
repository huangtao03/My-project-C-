using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Translate(new Vector3(0,0,1));//速度很快，因为每帧移动
         * vector.forward是快捷方式，接下来用该方式移动*/
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);//匀速移动【每秒多少米的方式移动，而不是每帧多少米】

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        }            /*transform.Rotate所需的两个参数
             * 1.Vector.up 表示围绕哪一个轴转
             * 2.旋转量
             */
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow)) 
            { 
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime); 
            }

    }
}
