using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //调用的函数，延迟时间，间隔时间（秒）
        InvokeRepeating("SpawnObject", 2, 1);
        Invoke("ExecuteAction", 3.0f); // 延迟3秒后执行
        //CancelInvoke("SpawnObject");

    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target,new Vector3(x,2,z),Quaternion.identity);
    }

    private void ExecuteAction()
    {
        Debug.Log("Action executed after 3 seconds.");
        // 执行停止调用    //停用函数
        CancelInvoke("SpawnObject");
    }
}
