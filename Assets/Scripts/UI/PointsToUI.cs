using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Game;

namespace Game.UI
{

    [RequireComponent(typeof(TextMeshProUGUI))]
    public class PointsToUI : MonoBehaviour
    {
        private TextMeshProUGUI text;

        private void Start()
        {
            text = GetComponent<TextMeshProUGUI>();
            GameManager.Instance.OnEndGame.AddListener(UpdateValue);
            UpdateValue();
        }

        private void UpdateValue()
        {
            text.text = $"{GameManager.Instance.PlayerPoints}:{GameManager.Instance.EnemyPoints}";
        }
    }
}