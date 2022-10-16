using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardButtons : MonoBehaviour
{
    [SerializeField] private KeyCode up;
    [SerializeField] private KeyCode down;
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode right;

    public KeyCode Up => up;
    public KeyCode Down => down;
    public KeyCode Left => left;
    public KeyCode Right => right;
}
