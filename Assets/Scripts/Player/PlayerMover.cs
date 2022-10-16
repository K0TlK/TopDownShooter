using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private Joystick joystickMove;
        [SerializeField] private Joystick joystickArrow;
        [SerializeField] private float speed = 3f;
        [SerializeField] private NavMeshAgent navAgent;

        private void Update()
        {
            Vector3 moveDir = new Vector3(joystickMove.Direction.x, 0, joystickMove.Direction.y);
            navAgent.velocity = moveDir * speed * 2.5f;

            if (joystickArrow.Direction != Vector2.zero)
            {
                Quaternion rotation = Quaternion.LookRotation(
                    new Vector3(joystickArrow.Direction.x, 0, joystickArrow.Direction.y), Vector3.up);
                transform.rotation = rotation;
            }
        }

        public void Active()
        {
            navAgent.enabled = true;
        }

        public void Deactive()
        {
            navAgent.enabled = false;
        }
    }
}
