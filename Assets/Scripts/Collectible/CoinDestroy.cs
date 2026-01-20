using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
