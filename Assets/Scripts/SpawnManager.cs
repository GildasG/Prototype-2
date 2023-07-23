using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] aggressiveAnimals;
    private float spawnRangeX = 18;
    private float spawnRangeZ = 15;
    private float spawnPosX = 20;
    private float spawnPosZ = 25;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomManager", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightManager", Random.Range(5.0f, 10.0f), Random.Range(4.0f, 8.0f));
        InvokeRepeating("SpawnLeftManager", Random.Range(5.0f, 10.0f), Random.Range(4.0f, 8.0f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomManager()
    {
        // Randomly generate animal index and position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRightManager()
    {
        // Randomly generate an aggressive animal coming form the right
        int aggressiveIndexR = Random.Range(0, aggressiveAnimals.Length);
        Vector3 spawnR = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));

        Instantiate(aggressiveAnimals[aggressiveIndexR], spawnR, aggressiveAnimals[aggressiveIndexR].transform.rotation * Quaternion.Euler(0, 180, 0));
    }
    void SpawnLeftManager()
    {
        // Randomly generate an aggressive animal coming form the left
        int aggressiveIndexL = Random.Range(0, aggressiveAnimals.Length);
        Vector3 spawnL = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));

        Instantiate(aggressiveAnimals[aggressiveIndexL], spawnL, aggressiveAnimals[aggressiveIndexL].transform.rotation);
    }
        
    


}
