using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public float range = 10;
    public TMPro.TMP_Text textOutput;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");//水平左右
        float v = Input.GetAxis("Vertical");//垂直上下
        float xPos = h * range;
        float yPos = v * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned:" + h.ToString("F2")+"\nVertical Value Returned:"+v.ToString("F2");
    }
}
