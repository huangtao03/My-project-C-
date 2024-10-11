using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    private void OnMouseDown()
    {
        print("SSS");
        rigidbody.AddForce(-transform.forward * 500f);
        rigidbody.useGravity = true;
    }
}
