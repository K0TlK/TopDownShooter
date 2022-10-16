using Base;
using Bow;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private PlayerMover player;
        [SerializeField] private EnemyMover enemy;
        public UnityEvent OnEndGame;

        private readonly string valuePlayer = "valuePlayer";
        private readonly string valueEnemy = "valueEnemy";
        private int playerPoints;
        private int enemyPoints;
        public int PlayerPoints => playerPoints;
        public int EnemyPoints => enemyPoints;

        private void Awake()
        {
            playerPoints = PlayerPrefs.GetInt(valuePlayer, 0);
            enemyPoints = PlayerPrefs.GetInt(valueEnemy, 0);
            OpenMenu();
        }

        public void OpenMenu()
        {
            SceneManager.Instance.OpenMenu();
        }

        public void StartGame()
        {
            SceneManager.Instance.StartGame();
        }

        public void EndGame(bool PlayerWin = true)
        {
            if (PlayerWin)
            {
                playerPoints++;
            }
            else
            {
                enemyPoints++;
            }
            PlayerPrefs.SetInt(PlayerWin ? valuePlayer : valueEnemy,
                PlayerWin ? playerPoints : enemyPoints);
            ArrowRemover.Instance.Clear();
            OpenMenu();
            OnEndGame.Invoke();
        }
    }
}