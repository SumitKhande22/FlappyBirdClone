using UnityEngine;

public class Background : MonoBehaviour
{
   [SerializeField] private float scrollSpeed = 1.0f;
    private float width;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
        if (Mathf.Abs(transform.position.x) <= -width)
        {
            transform.position += Vector3.right * width * 2f;
        }
    }
}
