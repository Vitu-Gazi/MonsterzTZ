using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : Singleton<EndGame>
{
    [SerializeField] private RecorderController recorderController;
    [SerializeField] private GameObject losePanel;

    public void EndTheGame ()
    {
        ObstacleSpawner.Instance.StopSpawn();

        recorderController.GetRecords();
        losePanel.SetActive(true);
    }
}
