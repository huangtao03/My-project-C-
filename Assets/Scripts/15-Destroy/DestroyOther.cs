using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject other;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
            //Destroy(other,3f);
            //第二个参数用来延迟
        }
    }
}
