using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    private Transform player;
   
 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if(Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

        else if (Vector3.Distance(transform.position,player.position) < stoppingDistance && Vector3.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }

        else if (Vector3.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            EnemyKilled();
            ScoreController.scoreVal += 1;
            if((ScoreController.scoreVal % 20) == 0 && ScoreController.scoreVal != 0)
            {
                ScoreController.waveNumber += 1;
            }
        }
    }

    public void EnemyKilled()
    {


        Destroy(gameObject);
    }

}
