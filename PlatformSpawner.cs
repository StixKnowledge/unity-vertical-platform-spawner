using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject platformPrefab;

    [Header("Spawn Settings")]
    public int maxPlatforms = 50;        // The total limit of platforms for the level
    public int initialPlatforms = 10;
    public float verticalGap = 2.5f;
    public float horizontalRange = 2.5f;
    public float initialPlatformYPosition = 1.5f;

    private int platformsSpawned = 0;    // Counter to track progress
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Spawn initial batch up to the limit
        for (int i = 0; i < initialPlatforms; i++)
        {
            if (platformsSpawned < maxPlatforms)
            {
                SpawnPlatform();
            }
        }
    }

    private void Update()
    {
        // 1. Check if we have already reached the limit
        if (platformsSpawned >= maxPlatforms) return;

        // 2. Check if the player is high enough to need a new platform
        // We only spawn if the "next" platform height is within 10 units of the player
        if (playerTransform.position.y > initialPlatformYPosition - 10f)
        {
            SpawnPlatform();
        }

        if (platformsSpawned == maxPlatforms)
        {
            // You could spawn a "Finish Line" or "Golden Platform" here
            Debug.Log("Level Generation Complete!");
        }
    }

    void SpawnPlatform()
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = initialPlatformYPosition;
        spawnPosition.x = Random.Range(-horizontalRange, horizontalRange);

        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        initialPlatformYPosition += verticalGap;
        platformsSpawned++; // Increment the counter

        // Debug message to see progress in the Console
        Debug.Log($"Spawned platform {platformsSpawned} of {maxPlatforms}");
    }
}