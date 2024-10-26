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
//        /*构造函数创建类或struct时都要调用构造函数，类或struct可能有多个构造函数，这些函值，限制实例化以及编写炅活易读的代码。
//        构造函数的注意事项:
//        1、构造函数的名称始终是类的名称。
//        2、构造函数一定不会有返回类型，连void都不会有。
//        3、一个类可能有多个不同的构造函数，但对象初始化时只会调用其中一个构造
//        4、快捷键ctor*/
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

//        //创建 stuff 类的实例(对象)
//        public Stuff mystuff =new Stuff(50,5,5);
//        public Stuff myotherstuff = new Stuff(50,1.5f);//因为参数类型不同，所以会自动识别调用哪个构函数
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

    // 创建 Stuff 类的实例（对象）
    public Stuff mystuff = new Stuff(50, 5, 5);
    public Stuff myotherstuff = new Stuff(50, 1.5f); // 因为参数类型不同，所以会自动识别调用哪个构造函数

    void Start()
    {
        Debug.Log(mystuff.bullets);
    }
}
