using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : Singleton<StartGame>
{
    [SerializeField] private ChooseComplexity chooseComplexity;
    [SerializeField] private RecorderController recorderController;
    [SerializeField] private CameraController cameraController;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform spawnPoint;

    public void StartTheGame()
    {
        losePanel.SetActive(false);

        GameObject player = Instantiate(this.player);

        player.transform.position = spawnPoint.position;
        player.GetComponent<BallSpeed>().SetSpeed((Complexity)chooseComplexity.CurrentComplexity);
        cameraController.SetTarget(player.transform);

        recorderController.StartTimer();
    }
}
