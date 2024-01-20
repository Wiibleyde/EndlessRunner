using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Spawnable objects
    public GameObject[] spawnableObjects;
    // Spawn interval
    public float[] spawnRangeInterval = { 1f, 2f };

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            Instantiate(spawnableObjects[Random.Range(0, spawnableObjects.Length)], transform.position, Quaternion.identity);
            float waitTime = Random.Range(spawnRangeInterval[0], spawnRangeInterval[1]);
            yield return new WaitForSeconds(waitTime);
        }

    }
    
}