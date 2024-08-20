using System.Diagnostics;
using UnityEngine;
using TMPro;
using System;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private TextMeshProUGUI isGameOverText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (scoreCounter.GetScore() >= 5)
            {
                isGameOverText.color = Color.green;
                isGameOverText.text = "You Win!";
                Time.timeScale = 0f;
            }

            else
            {
                isGameOverText.text = "You have yet to collect 5 coins\n Game Over!";
                Time.timeScale = 0f;
            }
        }
    }
}
