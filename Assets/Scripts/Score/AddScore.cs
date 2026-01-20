using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {  
            ScoreManager.instance.IncreaseScore(1);
            AudioManager.instance.PlaySound(AudioManager.instance.point);
            Debug.Log("Score Increased! Current Score: " + ScoreManager.instance.GetScore());
        }
        
    }
}
