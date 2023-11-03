using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] bool isCountDown;
    float time;
    TimeSpan timespan;
    bool isRunning = true;

    private void Update()
    {
        if (isRunning)
        {
            time += Time.deltaTime;
            timespan = TimeSpan.FromSeconds(time);
            timerText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timespan.Hours, timespan.Minutes, timespan.Seconds);
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}
