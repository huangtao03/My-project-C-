using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;




    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            //Rigidbody instance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;//��һ���������봫
            rocketInstance.AddForce(barrelEnd.forward * 5000);//����ǰ��������


        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        // ÿ�ΰ��¿ո��ʱʵ����һ���¶���
        //        Rigidbody instance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);
        //    }

    }
}
