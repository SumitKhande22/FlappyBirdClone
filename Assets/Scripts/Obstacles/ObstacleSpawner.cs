using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]private GameObject obstaclePrefab;
    [SerializeField] private float spawnRate = 2.0f;
    [SerializeField]private float heightRange = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle",0,spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        float raandomY = Random.Range(-heightRange, heightRange);
        Vector3 spawnPos = new Vector3(transform.position.x,raandomY,0);
        Instantiate(obstaclePrefab,spawnPos,Quaternion.identity);
    }
}
