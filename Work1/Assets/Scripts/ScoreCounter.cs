using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject finishLine;
    private int score = 0;

    public void IncScore()
    {
        score++;
        UpdateScoreText();
        if (score >= 5)
        {
            SetFinishLineColor(Color.green);
            UnityEngine.Debug.Log(finishLine.GetComponent<SpriteRenderer>().color);
        }
    }

    private void SetFinishLineColor(Color color)
    {
        SpriteRenderer renderer = finishLine.GetComponent<SpriteRenderer>();
        renderer.color = color;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Your Score: " + score;
    }

    public int GetScore()
    {
        return score;
    }
}
