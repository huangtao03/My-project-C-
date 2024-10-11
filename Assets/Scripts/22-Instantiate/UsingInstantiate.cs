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
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;//第一给参数必须传
            rocketInstance.AddForce(barrelEnd.forward * 5000);//加向前的作用力


        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        // 每次按下空格键时实例化一个新对象
        //        Rigidbody instance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);
        //    }

    }
}
