using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class ClockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject clockPrefab;
    [SerializeField] private float spawnInterval = 10f;
    [SerializeField] private float clockLifetime = 4f;
    [SerializeField] private Vector3[] spawnPositions = new Vector3[3];

    void Start()
    {
        StartCoroutine(SpawnClocks());
    }

    private IEnumerator SpawnClocks()
    {
        while (true)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            GameObject clock = Instantiate(clockPrefab, spawnPosition, Quaternion.identity);
            Destroy(clock, clockLifetime);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        int randomIndex = UnityEngine.Random.Range(0, spawnPositions.Length);
        return spawnPositions[randomIndex];
    }

}
