using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    //public Transform startPoint;
    //public Transform endPoint;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float t = Time.time / 2.0f;//插值系数随时间变化
    //    transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
    //}
    public float walkSpeed = 1.0f;
    public float runSpeed = 10.0f;

    private void Update()
    {
        float t = Input.GetAxis("Horizontal");//插入系数根据玩家输入变化
        float speed = Mathf.Lerp(walkSpeed, runSpeed, t);
        transform.Translate(Vector3.forward *  speed * Time.deltaTime);
    }
}
