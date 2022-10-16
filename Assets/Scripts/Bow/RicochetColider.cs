using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bow
{
    public class RicochetColider : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.transform.parent.TryGetComponent(out ArrowController arrow))
            {
                Vector3 reflectedPosition = Vector3.Reflect(arrow.transform.forward, collision.contacts[0].point);
                Debug.DrawLine(arrow.transform.position - arrow.transform.forward, collision.contacts[0].point, Color.red, 1.0f);
                Debug.DrawLine(collision.contacts[0].point, collision.contacts[0].point + reflectedPosition, Color.green, 1.0f);
                arrow.Ricochet(reflectedPosition);
            }
        }
    }
}