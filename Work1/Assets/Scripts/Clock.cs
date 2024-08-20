using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Timer timer;

    void Start()
    {
        timer = FindObjectOfType<Timer>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            timer.IncTime();
            Destroy(gameObject);
        }
    }
}
