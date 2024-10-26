using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletspeed;
    private Inventory inventory;
    void Awake()
    {
         inventory = GetComponent<Inventory>();
        // ���� inventoryGameObject ��һ������ Inventory �ű�����Ϸ����
        //Inventory inventory = inventoryGameObject.GetComponent<Inventory>();
        //if (inventory != null)
        //{
        //    Debug.Log(inventory.mystuff.bullets);
        //}
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.mystuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as
            Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletspeed);
            inventory.mystuff.bullets--;
        }

    }
}
