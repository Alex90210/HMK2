using UnityEngine;

public class GolfBallController : MonoBehaviour
{
    private ScoreManager scoreManager;
    private Vector3 initialPosition;
    private Rigidbody rb;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager not found in the scene!");
        }

        initialPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GolfHole"))
        {
            if (scoreManager != null)
            {
                scoreManager.IncrementScore();
            }
            else
            {
                Debug.LogError("ScoreManager is null, can't increment score!");
            }

            RespawnBall();
        }
    }

    void RespawnBall()
    {
        transform.position = initialPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}