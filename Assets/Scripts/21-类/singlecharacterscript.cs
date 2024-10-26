using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
public class singlecharacterscript : MonoBehaviour
{
    public class stuff
    {
        public int bullets;//子弹
        public int grenades;//手榴弹
        public int rockets;//火箭
        public stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

    }


    public stuff mystuff = new stuff(10, 7, 25);//使用构造函数
    public float speed;
    public float turnspeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletspeed;
    void Update()
    {
        Movement();
        shoot();
    }

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime;
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void shoot()
    {
        if (Input.GetButtonDown("Fire1") && mystuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletspeed);
            mystuff.bullets--;
        }


    }
}

