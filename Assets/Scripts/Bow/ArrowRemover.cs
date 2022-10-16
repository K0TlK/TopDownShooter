using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRemover : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            Destroy(other.gameObject, 2.0f);
        }
    }
}
