using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{

    public Text timerText;
    public float StartTime;
    private bool finish = false;

    void Start()
    {
        StartTime = 60.0f;
    }

    void Update()
    {
        StartTime -= Time.deltaTime;
        string minutes = ((int)StartTime / 60).ToString();
        string seconds = (StartTime % 60).ToString("f2");
        if (StartTime <= 0.000f)
        {
            seconds = "00";
            timerText.text = minutes + ":" + seconds;
            FinishTimer();
            return;
        }
        else
        {
            timerText.text = minutes + ":" + seconds;
        }
    }

    public void FinishTimer()
    {
        finish = true;
        timerText.color = Color.yellow;
    }
}

