using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodsSpawn : MonoBehaviour
{
    public GameObject[] asteriodPrefabs;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;
    // Use this for initialization
    void Spawn()
    {
        Vector3 rand = Random.insideUnitSphere * spawnRadius;
        rand.z = 0f;
        Vector3 position = transform.position + rand;
        int randIndex = Random.Range(0, asteriodPrefabs.Length);
        GameObject randAsteriod = asteriodPrefabs[randIndex];
        GameObject clone = Instantiate(randAsteriod);
        clone.transform.position = position;
    }
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
