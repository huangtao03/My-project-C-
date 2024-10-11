using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisExample : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 5;
    public TMPro.TMP_Text textOutput;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;


        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned:" + h.ToString("F2");
    }
}
