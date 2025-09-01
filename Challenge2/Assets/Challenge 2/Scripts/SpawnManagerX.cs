using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float intervalUpperRange = 5.0f;
    private float intervalLowerRange = 3.0f;
    private bool start = true;
    //private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAtRandomInterval());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int RandomIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[RandomIndex], spawnPos, ballPrefabs[RandomIndex].transform.rotation);
    }

    IEnumerator SpawnAtRandomInterval()
    {
        while (true)
        {
            if (start)
            {
                yield return new WaitForSeconds(startDelay);
                start = false;
                Debug.Log("Interval: " + startDelay);
            }
            else
            {
                float randomInterval = Random.Range(intervalLowerRange, intervalUpperRange);
                yield return new WaitForSeconds(randomInterval);
                Debug.Log("Interval: " + randomInterval);
            }
            SpawnRandomBall();
        }
        
    }

}
