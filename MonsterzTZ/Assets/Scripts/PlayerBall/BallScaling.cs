using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScaling : MonoBehaviour
{
    [SerializeField] private BallMover ballMover;
    [SerializeField] private Vector3 defaultScale;
    [SerializeField] private float scalingTime;

    private void Start()
    {
        transform.localScale = Vector3.zero;
        SetUpScale();
    }

    public void SetUpScale ()
    {
        transform.DOScale(defaultScale, scalingTime).SetEase(Ease.Linear).OnComplete(() => ballMover.SetCanMove(true));
    }
    public void SetDownScale()
    {
        transform.DOScale(Vector3.zero, scalingTime).SetEase(Ease.Linear).OnComplete(() => Destroy(gameObject));
    }
}
