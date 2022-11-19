using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;

public class RecorderController : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text attemptsText;

    private float currentTime;
    private IDisposable timer;
    private PrefsValue<int> attempts;

    private void Start()
    {
        attempts = new PrefsValue<int>("attempts", 0);
        currentTime = 0;
    }

    public void GetRecords ()
    {
        timer?.Dispose();
        timeText.text = "Time: " + currentTime.ToString();
        attempts.Value++;
        attemptsText.text = "Attempts: " + attempts.Value.ToString();
    }

    public void StartTimer ()
    {
        currentTime = 0;
        timer?.Dispose();
        timer = Observable.Interval(System.TimeSpan.FromSeconds(1)).TakeUntilDisable(gameObject).Subscribe(_ => { currentTime += 1f;});
    }
}
