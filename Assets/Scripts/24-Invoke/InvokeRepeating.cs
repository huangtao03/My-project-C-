using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //���õĺ������ӳ�ʱ�䣬���ʱ�䣨�룩
        InvokeRepeating("SpawnObject", 2, 1);
        Invoke("ExecuteAction", 3.0f); // �ӳ�3���ִ��
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
        // ִ��ֹͣ����    //ͣ�ú���
        CancelInvoke("SpawnObject");
    }
}
