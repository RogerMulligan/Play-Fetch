using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -35;
    private float spawnLimitXRight = 8;
    private float spawnPosY = 22;

    private float startDelay = 0.5f;
    private float minRespawn = 3.0f;
    private float maxRespawn = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, (float)(Random.Range(minRespawn, maxRespawn)));
       
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

   
}
