using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array de objetos a spawnear
    public float minX = -3f;
    public float maxX = 3f;
    public float maxY = 14f;
    public float minY = -4f;
    public float minInterval = 1f; // Intervalo m�nimo en segundos
    public float maxInterval = 5f; // Intervalo m�ximo en segundos

    void Start()
    {
        // Invocar la funci�n SpawnObjects con un intervalo aleatorio
        InvokeRepeating("SpawnObjects", Random.Range(minInterval, maxInterval), Random.Range(minInterval, maxInterval));
    }

    void SpawnObjects()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), maxY, -7.748f);
        int randomIndex = Random.Range(0, objectsToSpawn.Length);
        GameObject spawnedObject = Instantiate(objectsToSpawn[randomIndex], spawnPosition, Quaternion.identity);

        // Destruir el objeto si baja de -4 en Y
        if (spawnedObject.transform.position.y < minY)
        {
            Destroy(spawnedObject);
        }
    }
}

