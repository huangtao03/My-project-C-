using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    void Update()
    {
        //�����˶�С����
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

        // �����ƶ�����
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized * speed * Time.deltaTime;

        // ���������λ��
        transform.Translate(movement);
        /*�����Ƕ�Ӧ��KeyCodeö��ֵ��

        �ϼ�ͷ(Up Arrow)��KeyCode.UpArrow
        �¼�ͷ(Down Arrow)��KeyCode.DownArrow
        ���ͷ(Left Arrow)��KeyCode.LeftArrow
        �Ҽ�ͷ(Right Arrow)��KeyCode.RightArrow
        ����״̬��
Input.GetKey���ڼ�ⰴ���Ƿ��ڵ�ǰ֡�������¡�
Input.GetKeyDown���ڼ�ⰴ���ڵ�ǰ֡�Ƿ�ոհ��¡�
Input.GetKeyUp���ڼ�ⰴ���ڵ�ǰ֡�Ƿ�ո��ͷš�
        */
    }
}
