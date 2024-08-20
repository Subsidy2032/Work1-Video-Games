using UnityEngine;
using System.Diagnostics;
using TMPro;
using System.Threading;

public class TouchEdges : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI isGameOverText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RoadEdge"))
        {
            isGameOverText.text = "You touched the edge!\n Game Over!";
            UnityEngine.Debug.Log("Player has touched a road edge!");
            Time.timeScale = 0f;
        }
    }
}
