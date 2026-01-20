using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed of the obstacle movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position += Vector3.left * speed * Time.deltaTime;
        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }
}
