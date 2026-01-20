using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField]private int score=0;
    private int highScore=0;
    [SerializeField]private TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore(int increaseScore)
    {
        score += increaseScore;
        scoreText.text = "Score: " + score.ToString();
        CheckHighScore();

    }
    public void CheckHighScore()
    {
        if (score>highScore)
        {
            highScore=score;
            PlayerPrefs.SetInt("HighScore",highScore);
            PlayerPrefs.Save();
            Debug.Log("New High Score: " + highScore);
        }
    }
    public int GetScore()
    {
        return score;
    }
    public int GetHighScore()
    {
        return highScore;
    }
    public void ResetScore()
    {
        highScore = 0;
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("HighScore");
    }
}
