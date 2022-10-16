using Bow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent navAgent;
        [SerializeField] private Transform target;
        [SerializeField] private BowController tmp;
        private bool isActive = false;

        private void Update()
        {
            if (isActive)
            {
                navAgent.SetDestination(target.position);
                transform.LookAt(target);
                tmp.ActiveBow();
            }
            else
            {
                tmp.DeactiveBow();
            }
        }

        public void Active()
        {
            navAgent.enabled = true;
            isActive = true;
        }

        public void Deactive()
        {
            navAgent.enabled = false;
            isActive = false;
        }
    }
}