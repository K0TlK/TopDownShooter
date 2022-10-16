using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private GameObject trail;
    [SerializeField] private float speed = 5.0f;
    private bool isActive = false;
    
    private void Awake()
    {
        trail.SetActive(false);
        AnimOpen();
    }

    private void Update()
    {
        if (isActive)
        {
            FlightForward();
        }
    }

    public void Shoot()
    {
        isActive = true;
        trail.SetActive(true);
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
}
