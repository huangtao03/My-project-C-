using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 10;
        string message;
        //这是一个三元与运算的示例，其中根据变量“health”选择一条消息。
        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
