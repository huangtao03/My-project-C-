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
        /*transform.Translate(new Vector3(0,0,1));//�ٶȺܿ죬��Ϊÿ֡�ƶ�
         * vector.forward�ǿ�ݷ�ʽ���������ø÷�ʽ�ƶ�*/
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);//�����ƶ���ÿ������׵ķ�ʽ�ƶ���������ÿ֡�����ס�

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        }            /*transform.Rotate�������������
             * 1.Vector.up ��ʾΧ����һ����ת
             * 2.��ת��
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
