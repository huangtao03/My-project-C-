using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.white;

        }
        if (Input.GetKeyDown(KeyCode.B))    {
            GetComponent<Renderer>().material.color = Color.blue;

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.gray;

        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.black;

        }
    }
}