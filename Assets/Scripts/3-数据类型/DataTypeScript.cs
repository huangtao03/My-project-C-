using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //值类型变量
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 2);
        //引用类型变量
        Transform tran = transform;
        tran.position = new Vector3(0,2,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
