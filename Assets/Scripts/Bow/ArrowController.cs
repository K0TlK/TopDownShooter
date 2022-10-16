using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Game;

namespace Bow
{
    public class ArrowController : MonoBehaviour
    {
        [SerializeField] private CapsuleCollider capsuleCollider;
        [SerializeField] private GameObject trail;
        [SerializeField] private float speed = 5.0f;
        [SerializeField] private Rigidbody rb;
        private bool isActive = false;
        private int ricochetCount = 2;

        private void Awake()
        {
            trail.SetActive(false);
            AnimOpen();
            rb.isKinematic = true;
        }

        private void Update()
        {
            if (isActive)
            {
                FlightForward();
            }
        }

        private IEnumerator ActiveCollider()
        {
            yield return new WaitForSeconds(0.25f);
            trail.SetActive(true);
            capsuleCollider.enabled = true;
        }

        public void Shoot()
        {
            isActive = true;
            StartCoroutine(ActiveCollider());
            rb.isKinematic = false;
        }

        private void FlightForward()
        {
            transform.position += Time.deltaTime * speed * transform.forward;
        }

        public void AnimOpen(float duration = 1.0f)
        {
            transform.localScale = Vector3.zero;
            transform.DOScale(1, duration);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                GameManager.Instance.EndGame();
                return;
            }

            if (other.CompareTag("Player"))
            {
                GameManager.Instance.EndGame(false);
                return;
            }
        }

        public void Ricochet(Vector3 bounceDirection)
        {
            ricochetCount--;
            if (ricochetCount == 0)
            {
                Destroy(gameObject, 1f);
            }
            Vector3 tmp = Quaternion.LookRotation(bounceDirection, Vector3.up).eulerAngles;
            tmp.x = 0;
            transform.rotation = Quaternion.Euler(tmp);
        }
    }
}