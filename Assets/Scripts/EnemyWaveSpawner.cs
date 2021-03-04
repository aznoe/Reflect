using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyWaveSpawner : MonoBehaviour
{

    [SerializeField]
    public float spawnRadius = 7, time = 2.50f;
    public int enemyNow = 0;
    public int enemyMax = 35;
    private bool maxReached = false; // Bool that stores the Information if the maximum is reached

    public GameObject[] enemies; //List of enemies that can get spawned


    void Start()
    {
        StartCoroutine(SpawnEnemy()); //Start the Couroutine once at the start of the game
    }

    IEnumerator SpawnEnemy() // that is the important part
    {
        while (true)
        {
            if (!maxReached)
            {
                Vector2 spawnPos = GameObject.FindGameObjectWithTag("Player").transform.position; //Spawning an enemy
                spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
                
                Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
                yield return new WaitForSeconds(time);
                enemyNow++; // increase the enemy counter
                
            }
            yield return null;
        }
    }

    public void lowerMaxEnemy()
    {
        enemyNow--; // decrease the enemy counter if a enemy is killed(Kill is in another script)
    }
    public void Update()
    {
        maxReached = enemyNow >= enemyMax;
        
    }
  




    
}
