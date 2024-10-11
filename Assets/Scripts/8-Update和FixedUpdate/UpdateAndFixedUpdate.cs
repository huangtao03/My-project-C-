using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Debug.Log("FixdeUpdate time :" + Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update time :" + Time.deltaTime);
        /*        float moveSpeed = 5f;
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);*/
        float moveSpeed = 5f;
        GetComponent<Rigidbody>().AddForce(Vector3.forward *  moveSpeed,ForceMode.Force);

    }

/*    private void LateUpdate()
    {
        transform.position = target.position + offset;//Ïà»ú¸úËæ
    }*/
}
