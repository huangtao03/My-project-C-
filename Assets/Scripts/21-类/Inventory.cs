//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using static singlecharacterscript;

//public class Inventory : MonoBehaviour
//{
//    public class Stuff
//    {
//        public int bullets;
//        public int grenades;
//        public int rockets;
//        public float fuel;
//        /*���캯���������structʱ��Ҫ���ù��캯�������struct�����ж�����캯������Щ��ֵ������ʵ�����Լ���д�����׶��Ĵ��롣
//        ���캯����ע������:
//        1�����캯��������ʼ����������ơ�
//        2�����캯��һ�������з������ͣ���void�������С�
//        3��һ��������ж����ͬ�Ĺ��캯�����������ʼ��ʱֻ���������һ������
//        4����ݼ�ctor*/
//        public Stuff(int bul, int gre, int roc)
//        {
//            bullets = bul;
//            grenades = gre; 
//            rockets = roc;
//        }

//        public Stuff(int bul, float fu)
//        {
//            bullets = bul;
//            fuel = fu;
//        }
//        public Stuff()
//        {
//            bullets = 1;
//            grenades = 1;
//            rockets = 1;
//        }

//        //���� stuff ���ʵ��(����)
//        public Stuff mystuff =new Stuff(50,5,5);
//        public Stuff myotherstuff = new Stuff(50,1.5f);//��Ϊ�������Ͳ�ͬ�����Ի��Զ�ʶ������ĸ�������
//        void start()
//        {
//            Debug.Log(mystuff.bullets);
//        }
//    }

using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    // ���� Stuff ���ʵ��������
    public Stuff mystuff = new Stuff(50, 5, 5);
    public Stuff myotherstuff = new Stuff(50, 1.5f); // ��Ϊ�������Ͳ�ͬ�����Ի��Զ�ʶ������ĸ����캯��

    void Start()
    {
        Debug.Log(mystuff.bullets);
    }
}
