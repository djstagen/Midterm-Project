using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnPosY = 0.0f;


    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float startDelay = 2;
    [SerializeField] GameObject[] objectPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);    
    }

    // Update is called once per frame
    void Update()
    {
        //randomly generate object index and spawn position

    }

    void SpawnRandomObject()
    {
        int objectIndex = Random.Range(0, objectPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
        Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);
    }
}
