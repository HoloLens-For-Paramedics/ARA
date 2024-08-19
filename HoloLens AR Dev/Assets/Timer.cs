using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;

    void Update()
    {
        string currentTime = DateTime.Now.ToString("HH:mm:ss");
        timerText.text = currentTime;
    }
}
