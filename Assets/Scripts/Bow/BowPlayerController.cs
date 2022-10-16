using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bow
{
    public class BowPlayerController : BowController
    {
        [SerializeField] private Joystick joystickArrow;

        void Update()
        {
            if (joystickArrow.Direction != Vector2.zero)
            {
                Shoot();
            }
        }
    }
}