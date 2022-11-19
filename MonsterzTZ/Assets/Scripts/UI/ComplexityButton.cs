using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComplexityButton : MonoBehaviour
{
    [SerializeField] private Image buttonImage;
    [SerializeField] private Complexity complexity;

    public static Action<Complexity> SetStateButton;

    private void Awake ()
    {
        SetStateButton += SetState;
    }
    private void OnDestroy()
    {
        SetStateButton -= SetState;
    }

    private void SetState (Complexity choosedComplexity)
    {
        if (complexity == choosedComplexity)
        {
            buttonImage.color = Color.green;
        }
        else
        {
            buttonImage.color = Color.red;
        }
    }
}
