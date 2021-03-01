using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    // Start is called before the first frame update
    public int xRange = 20;
    private float startDelay = 2f;
    private float spawnDelay = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.S))
		{
            SpawnRandomAnimals();
		}
    }

    void SpawnRandomAnimals()
	{
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), 0, 20);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
