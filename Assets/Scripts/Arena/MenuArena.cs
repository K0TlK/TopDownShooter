using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arena
{
    public class MenuArena : MonoBehaviour
    {
        [SerializeField] private Transform enemy;
        [SerializeField] private Transform player;

        public void SetEnemy(Transform obj)
        {
            obj.SetParent(enemy);
            obj.localRotation = Quaternion.identity;
            obj.localPosition = Vector3.zero;
        }
        public void SetPlayer(Transform obj)
        {
            obj.SetParent(player);
            obj.localRotation = Quaternion.identity;
            obj.localPosition = Vector3.zero;
        }
    }
}
