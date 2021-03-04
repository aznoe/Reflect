using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    public float attackRange;
    private float distanceToTarget;
    private Transform player;


    void Start()
    {
        timeBtwShots = startTimeBtwShots;
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(transform.position, player.position);

        if (distanceToTarget < attackRange)
        {
            
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
        
    }
}
