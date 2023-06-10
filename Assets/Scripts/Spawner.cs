using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform snake;

    public GameObject[] Trash;

    public Transform[] SpawnPoint;

    void Start()
    {
        InvokeRepeating("SpawnTrash", 2, Random.Range(2,5));
    }

    void Update()
    {
        transform.position = snake.position;
    }

    void SpawnTrash()
    {
        Instantiate(Trash[Random.Range(0,2)], SpawnPoint[Random.Range(0,4)].position, Quaternion.identity);
    }
}
