using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshPro scoreText;
    private int score = 0;

    void Start()
    {
        ResetScore();
    }

    public void IncrementScore()
    {
        score++;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Balls in Hole: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreDisplay();
    }
}