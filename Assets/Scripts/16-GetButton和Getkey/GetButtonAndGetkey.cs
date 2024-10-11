using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtonAndGetkey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))//按下
        {
            print("ButtonDown");
        }
        if (Input.GetButton("Jump"))//GetButtonKeep同理按住
        {
            print("ButtonHold");
        }
        if (Input.GetButtonUp("Jump"))//松开
        {
            print("ButtonUp");
        }
        //if (Input.GetKeyDown(KeyCode.A))//按下
        //{
        //    print("KeyDown");
        //}
        //if (Input.GetKey(KeyCode.A))//GetKeyKeep同理按住
        //{
        //    print("KeyHold");
        //}
        //if (Input.GetKeyUp(KeyCode.A))//松开
        //{
        //    print("KeyUp");
        //}
    }
}
