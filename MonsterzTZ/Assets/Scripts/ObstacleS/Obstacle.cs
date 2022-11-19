using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out BallDeathController ball))
        {
            ball.Death();
            EndGame.Instance.EndTheGame();
        }
    }
}
