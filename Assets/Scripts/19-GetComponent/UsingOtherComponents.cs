using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherGameObject;
    /*�������ű������ã����Խű�����Ϊ���ͱ���������Ϊ���� ʵ�����õ�������ű��ж�������ʵ��*/
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    //��Awake�����У����б�����ʼ��
    private void Awake()
    {
        /*1��<>�������������ͳ�Ϊ����
         * 2������GetComponent���������������õ�������Ϸ�������GetComponent�᷵�ص���������Ϸ����������ָ���������������
         * 3��GetComponent��ռ�ô����������������Ծ������ٵ��ã��������Awake��Start�����е��ã�������״���Ҫʱ����һ��
         * */
        anotherScript = otherGameObject.GetComponent<AnotherScript>();//1,2,3
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();//4
        boxCol = otherGameObject.GetComponent<BoxCollider>();//5
    }
    void Start()
    {
        
            //// �������Ƿ��ѱ���ȷ��ʼ��
            //if (anotherScript == null)
            //{
            //    Debug.LogError("AnotherScript is null in Start method.");
            //}
            //else
            //{
            //    Debug.Log("The player's score is " + anotherScript.playerScore);
            //}

            //if (yetAnotherScript != null)
            //{
            //    Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
            //}
            //else
            //{
            //    Debug.LogWarning("yetAnotherScript is null in Start method.");
            //}
    
        //if (anotherScript == null)
        //{
        //    Debug.LogError("AnotherScript is not attached to this GameObject.");
        //}
        //if (yetAnotherScript == null)
        //{
        //    Debug.LogError("YetAnotherScript is not attached to the specified GameObject.");
        //}
        //if (boxCol == null)
        //{
        //    Debug.LogError("BoxCollider is not attached to the specified GameObject.");
        //}
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + "times");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
