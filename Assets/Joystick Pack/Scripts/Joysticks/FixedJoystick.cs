using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJoystick : Joystick
{
    private void OnDisable()
    {
        base.OnPointerUp(null);
    }
}