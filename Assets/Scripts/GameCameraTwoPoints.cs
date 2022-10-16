using UnityEngine;

namespace CameraMover
{
    public class GameCameraTwoPoints : MonoBehaviour
    {
        [SerializeField] private Transform targetOne, targetTwo;
        [SerializeField] private float baseOffset = 5.0f;

        private void Update()
        {
            Vector3 beetwenPoints = (targetOne.position + targetTwo.position) / 2;
            float dist = Vector3.Distance(targetOne.position, beetwenPoints);
            float cameraAspectOffset = (Camera.main.aspect < 1) ? 1 : Camera.main.aspect;
            transform.position = new Vector3(beetwenPoints.x, dist / cameraAspectOffset + baseOffset, beetwenPoints.z);
        }
    }
}