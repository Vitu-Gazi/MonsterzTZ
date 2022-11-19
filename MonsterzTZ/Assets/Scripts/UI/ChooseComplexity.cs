using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseComplexity : MonoBehaviour
{
    private PrefsValue<int> complexity;

    public int CurrentComplexity => complexity.Value;

    private void Start()
    {
        complexity = new PrefsValue<int>("complexity", 1);
        ChangeComplexity(complexity.Value);
    }

    public void ChangeComplexity (int newComplexity)
    {
        complexity.Value = newComplexity;
        ComplexityButton.SetStateButton.Invoke((Complexity)newComplexity);
    }
}

public enum Complexity
{
    Easy = 0,
    Medium = 1,
    Hard = 2
}
