using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamEnemy : MonoBehaviour
{
    GameObject[] spawnPoint;
    public GameObject zombie;
    public float minSpawnTime = 0.2f;
    public float maxSpawnTime = 1f;
    private float lastSpawnTime = 0;
    private float spawnTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectsWithTag("Respawn");
        //UpdateSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastSpawnTime + spawnTime)
        {
            //Spawn();
        }
    }

    //void UpdateSpawnTime()
    //{
    //    lastSpawnTime = Time.time;
    //    spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    //}
    //void Spawn()
    //{
    //    int point = Random.Range(0, spawnPoint.Length);
    //    Instantiate(zombie, spawnPoint[point].transform.position, Quaternion.identity);
    //    UpdateSpawnTime();
    //}
}
