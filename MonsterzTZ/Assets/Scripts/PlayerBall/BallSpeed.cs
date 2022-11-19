using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    [SerializeField] private float upSpeed;
    [SerializeField] private float upSpeedTime;
    [SerializeField] private float upSpeedStep;
    [SerializeField] private float maxUpSpeed;

    [SerializeField] private float easySpeed;
    [SerializeField] private float mediumSpeed;
    [SerializeField] private float hardSpeed;

    private float currentSpeed;
    private float currentUpSpeed;

    public float CurrentSpeed => currentSpeed;
    public float CurrentUpSpeed => currentUpSpeed;

    private void Start()
    {
        currentUpSpeed = upSpeed;
        UpdateUpSpeed();
    }

    public void SetSpeed (Complexity complexity)
    {
        switch (complexity)
        {
            case Complexity.Easy:
                {
                    currentSpeed = easySpeed;
                }
                break;

            case Complexity.Medium:
                {
                    currentSpeed = mediumSpeed;
                }
                break;

            case Complexity.Hard:
                {
                    currentSpeed = hardSpeed;
                }
                break;
        }
    }

    private void UpdateUpSpeed()
    {
        Observable.Interval(System.TimeSpan.FromSeconds(upSpeedTime)).TakeWhile(x => currentUpSpeed < maxUpSpeed).TakeUntilDisable(gameObject)
        .Subscribe(_ => 
        {
            currentUpSpeed += upSpeedStep;
            currentUpSpeed = Mathf.Clamp(currentUpSpeed, 0, maxUpSpeed);
        });
    }
}