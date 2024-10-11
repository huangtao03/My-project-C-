using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "First dtring";
        strings[1] = "22";
        strings[2] = "33";
        foreach (string s in strings)
        {
            print(s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
