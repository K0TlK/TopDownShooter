using Base;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private PlayerMover player;
    [SerializeField] private EnemyMover enemy;

    private void Awake()
    {
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
        ArrowRemover.Instance.Clear();
        OpenMenu();
    }
}
