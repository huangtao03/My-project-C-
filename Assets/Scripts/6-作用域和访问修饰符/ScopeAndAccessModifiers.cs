using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    // Start is called before the first frame update
    //���������еı��� alpha beta gamma//
    public int alpha = 5;
    public int beta = 0;
    public int gamma = 5;


    private AnotherClass myOtherClass;
    void Start()
    {
        //�����������еı��� alpha
        alpha = 29;

        myOtherClass = new AnotherClass();//����AnotherClass���ʵ��
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);//ֻ�ܷ��ʸ����еĹ�������
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