using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float runningTime = 30f;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI isGameOverText;

    void Update()
    {
        if (runningTime > 0)
        {
            timeText.text = "Time Remaining: " + (Mathf.FloorToInt(runningTime).ToString());
            runningTime -= Time.deltaTime;
        }

        if (runningTime <= 0)
        {
            isGameOverText.text = "You ran out of time!\nGame Over!";
            Time.timeScale = 0f;
        }
    }

    public void IncTime()
    {
        runningTime += 5;
    }
}
