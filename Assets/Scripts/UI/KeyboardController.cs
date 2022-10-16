using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(KeyboardButtons))]
public class KeyboardController : FixedJoystick
{
    private Vector2 dir;
    public override Vector2 Direction => (dir == Vector2.zero) ? base.Direction : dir;
    private KeyboardButtons keyboardButtons;

    private void Awake()
    {
        keyboardButtons = GetComponent<KeyboardButtons>();
    }

    private void Update()
    {
        Vector2 newdir = Vector2.zero;
        if (Input.GetKey(keyboardButtons.Up)) newdir.y += 1;
        if (Input.GetKey(keyboardButtons.Left)) newdir.x -= 1;
        if (Input.GetKey(keyboardButtons.Down)) newdir.y -= 1;
        if (Input.GetKey(keyboardButtons.Right)) newdir.x += 1;
        dir = newdir;
    }

    private void OnDisable()
    {
        dir = Vector2.zero;
    }
}
