using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0F;
    private float spawnInterval = 5.0F;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3, spawnInterval));
    }

    void OnInvokeRepeating()
    {
        float newDelay = Random.Range(3, spawnInterval);

        CancelInvoke("SpawnRandomBall");

        InvokeRepeating("SpawnRandomBall", startDelay, newDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int randomIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);
    }

}
