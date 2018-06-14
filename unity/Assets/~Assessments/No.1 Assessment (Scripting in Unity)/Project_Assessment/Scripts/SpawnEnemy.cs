using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  SpawnEnemy : MonoBehaviour
{
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public GameObject enemy;
    // Use this for initialization
    void Start()
    {
        //Repeats what to spawn and the spawn time
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        // Tell us where it could spawn
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
