using UnityEngine;

public class HoleDetector : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            scoreManager.IncrementScore();
        }
    }
}