using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bow
{
    public class BowController : MonoBehaviour
    {
        [SerializeField] private ArrowController arrowPrefab;
        [SerializeField] private ArrowController arrowActive;
        [SerializeField] private Transform arrowPosition;
        [SerializeField] private BoxCollider arrowZone;

        public void Shoot()
        {
            arrowActive.transform.SetParent(arrowZone.transform);
            arrowActive.Shoot();
            arrowActive = Instantiate(arrowPrefab, arrowPosition);
            arrowActive.AnimOpen(1);
        }
    }

}