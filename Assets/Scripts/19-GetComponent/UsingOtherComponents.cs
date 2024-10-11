using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherGameObject;
    /*对其他脚本的引用，即以脚本名称为类型变量，是因为我们 实际引用的是这个脚本中定义的类的实例*/
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    //在Awake函数中，进行变量初始化
    private void Awake()
    {
        /*1·<>的作用是让类型成为参数
         * 2·调用GetComponent来访问我们所引用的其他游戏的组件，GetComponent会返回调用它的游戏对象中任意指定类型组件的引用
         * 3·GetComponent会占用大量处理能力，所以尽量减少调用，最好是在Awake和Start函数中调用，或仅在首次需要时调用一次
         * */
        anotherScript = otherGameObject.GetComponent<AnotherScript>();//1,2,3
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();//4
        boxCol = otherGameObject.GetComponent<BoxCollider>();//5
    }
    void Start()
    {
        
            //// 检查变量是否已被正确初始化
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
