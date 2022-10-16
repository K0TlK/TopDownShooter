using Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRemover : Singleton<ArrowRemover>
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            Destroy(other.gameObject, 2.0f);
        }
    }

    public void Clear()
    {
        foreach (var arrow in GetComponentsInChildren<ArrowController>())
        {
            Destroy(arrow.gameObject, 0.5f);
        }
    }
}
