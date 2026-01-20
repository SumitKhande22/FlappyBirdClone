using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]private GameObject coinPrefab;
    [SerializeField]private int coinsPerPlatform =1;
    [SerializeField]private float heighOffset = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("CoinPlatform");
        foreach (GameObject plat in platforms)
        {
            SpawnCoinsOnPlatform(plat);
        }
    }
    void SpawnCoinsOnPlatform(GameObject platform)
    {
        BoxCollider2D platformCol2D= platform.GetComponent<BoxCollider2D>();
        Vector2 size = platformCol2D.size;
        for (int i = 0; i< coinsPerPlatform; i++)
        {
            float randomX = Random.Range(-size.x / 2f, size.x / 2f);
            Vector2 spawnPos = (Vector2)platform.transform.position + new Vector2(randomX,heighOffset);

            GameObject newCoin= Instantiate(coinPrefab, spawnPos, Quaternion.identity);
            newCoin.transform.parent = platform.transform;
        }
    }
}
