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
        if (Input.GetButtonDown("Jump"))//����
        {
            print("ButtonDown");
        }
        if (Input.GetButton("Jump"))//GetButtonKeepͬ��ס
        {
            print("ButtonHold");
        }
        if (Input.GetButtonUp("Jump"))//�ɿ�
        {
            print("ButtonUp");
        }
        //if (Input.GetKeyDown(KeyCode.A))//����
        //{
        //    print("KeyDown");
        //}
        //if (Input.GetKey(KeyCode.A))//GetKeyKeepͬ��ס
        //{
        //    print("KeyHold");
        //}
        //if (Input.GetKeyUp(KeyCode.A))//�ɿ�
        //{
        //    print("KeyUp");
        //}
    }
}
