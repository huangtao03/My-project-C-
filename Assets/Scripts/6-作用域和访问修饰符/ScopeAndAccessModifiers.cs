using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    // Start is called before the first frame update
    //类作用域中的变量 alpha beta gamma//
    public int alpha = 5;
    public int beta = 0;
    public int gamma = 5;


    private AnotherClass myOtherClass;
    void Start()
    {
        //函数作用域中的变量 alpha
        alpha = 29;

        myOtherClass = new AnotherClass();//创建AnotherClass类的实例
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);//只能访问该类中的公开变量
    }

    // Update is called once per frame
    void Example (int pens,int crayons)
    {
        int answer;
        answer = pens * crayons  * alpha;
        Debug.Log(answer);
    }
    void Update()
    {
        Debug.Log("Alpha is set to: " +  alpha);
    }
    
}
public class AnotherClass {
    public int apples;
    public int bananas;


    private int stapler;
    private int sellotape;
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total:" + answer);
    }
    private void OfficeSort (int a,int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies tatal: " + answer);
    }
}