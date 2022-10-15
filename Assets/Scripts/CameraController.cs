using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform targetPosition;
    [SerializeField] private Transform targetRotation;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float xRotate = 30f;

    private void LateUpdate()
    {
        if (!targetPosition) return;
        if (!targetRotation) return;

        transform.position = Vector3.Lerp(transform.position, targetPosition.position, Time.deltaTime * speed);

        Vector3 tmp = targetRotation.rotation.eulerAngles;
        tmp.x = xRotate;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(tmp), Time.deltaTime * speed);
    }

    public void SetTarget(Transform target)
    {
        this.targetPosition = target;
    }

    public void SetTargetRotation(Transform target)
    {
        this.targetRotation = target;
    }
}
