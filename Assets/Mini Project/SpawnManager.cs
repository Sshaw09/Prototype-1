using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float SpawnRangeX = 7.0f;
    private float SpawnPosZ = 180.0f;
    private float startDelay = 3f;
    private float spawnInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCars", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCars()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);

        int carIndex = Random.Range(0, carPrefabs.Length);

        Instantiate(carPrefabs[carIndex], SpawnPos, carPrefabs[carIndex].transform.rotation);

    }
}
