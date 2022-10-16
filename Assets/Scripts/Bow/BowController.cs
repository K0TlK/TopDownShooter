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
        private bool isActive = true;
        private bool delay = false;

        public void ActiveBow()
        {
            if (!delay)
            {
                isActive = true;
                StartCoroutine(ShootActive());
            }
        }

        public void DeactiveBow()
        {
            isActive = false;
        }

        private IEnumerator ShootActive()
        {
            while (isActive)
            {
                yield return new WaitForEndOfFrame();
                if (!delay)
                {
                    delay = true;
                    arrowActive.transform.SetParent(ArrowRemover.Instance.transform);
                    arrowActive.Shoot();
                    arrowActive = Instantiate(arrowPrefab, arrowPosition);
                    arrowActive.AnimOpen(1);
                    yield return new WaitForSeconds(1.5f);
                    delay = false;
                }
            }
        }
    }

}