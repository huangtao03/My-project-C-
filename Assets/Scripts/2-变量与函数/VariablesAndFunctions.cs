using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;
    // Start is called before the first frame update
    /* void Start()
     {
         myInt = MultiplyByTwo(myInt);

         Debug.Log(myInt);
     }

     int MultiplyByTwo(int number)
     {
         int ret;
         ret = number * 2;
         return ret;
     }*/
    void Start()
    {
        MultiplyByTwo(out myInt);

        Debug.Log(myInt);
    }

    void MultiplyByTwo(out int number)
    {
        number = myInt;
        number = number * 2;
        
    }
}
