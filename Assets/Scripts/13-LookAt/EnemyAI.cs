using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        //如果玩家接近敌人，敌人转身面向玩家
        if (distanceToPlayer  < 10f)
        {
            transform.LookAt(player);
        }
    }
}
