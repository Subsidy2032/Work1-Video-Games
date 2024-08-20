using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float coinLifetime = 5f;
    [SerializeField] private Vector3[] spawnPositions = new Vector3[5];

    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
            Destroy(coin, coinLifetime);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        int randomIndex = UnityEngine.Random.Range(0, spawnPositions.Length);
        return spawnPositions[randomIndex];
    }

}
