using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeathController : MonoBehaviour
{
    [SerializeField] private BallScaling ballScaling;
    [SerializeField] private BallMover ballMover;

    public void Death ()
    {
        ballMover.SetCanMove(false);
        ballScaling.SetDownScale();
    }
}
