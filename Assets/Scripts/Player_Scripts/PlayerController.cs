using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            AudioManager.instance.PlayModifiedSound(AudioManager.instance.jump);
            Debug.Log("Jumped!");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
            Debug.Log("Destroy Object " +  gameObject);
            Debug.Log("Collided with Obstacle " + collision.gameObject);
            Debug.Log("Calling Game Over from PlayerController");
            AudioManager.instance.PlaySound(AudioManager.instance.die);
            GameManager.instance.GameOver();
            Debug.Log("Game Over!");    
        }
    }
}
