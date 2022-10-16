using Arena;
using Base;
using CameraMover;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class SceneManager : Singleton<SceneManager>
    {
        [SerializeField] private CameraController cameraController;
        [SerializeField] private ArenaController arena;
        [SerializeField] private GameCameraTwoPoints gameCameraTwoPoints;
        [SerializeField] private PlayerMover player;
        [SerializeField] private EnemyMover enemy;
        [SerializeField] private Joystick joystickA, joystickB;
        [SerializeField] private Button btPlay;

        public void OpenMenu()
        {
            cameraController.SetTarget(arena.Menu.transform);
            cameraController.SetXRotate(0);
            player.Deactive();
            enemy.Deactive();
            arena.Menu.SetEnemy(enemy.transform);
            arena.Menu.SetPlayer(player.transform);
            joystickA.gameObject.SetActive(false);
            joystickB.gameObject.SetActive(false);
            btPlay.gameObject.SetActive(true);
        }

        public void StartGame()
        {
            cameraController.SetTarget(gameCameraTwoPoints.transform);
            cameraController.SetXRotate(90);
            player.Active();
            enemy.Active();
            player.transform.SetParent(null);
            enemy.transform.SetParent(null);
            joystickA.gameObject.SetActive(true);
            joystickB.gameObject.SetActive(true);
            btPlay.gameObject.SetActive(false);
            arena.SpawnPoints.Reload();
            player.transform.position = arena.SpawnPoints.GetFreePoint().position;
            enemy.transform.position = arena.SpawnPoints.GetFreePoint().position;
            arena.SpawnObjects();
        }
    }
}