using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] ScoreCounter scoreCounter;

    private void Start()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            scoreCounter.IncScore();
            Destroy(gameObject);
        }
    }
}