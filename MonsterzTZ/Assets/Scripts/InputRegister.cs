using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRegister : Singleton<InputRegister>
{
    public Action<bool> UpInput;

    private void Update()
    {
        UpInput?.Invoke(Input.GetKey(KeyCode.Space));
    }
}
