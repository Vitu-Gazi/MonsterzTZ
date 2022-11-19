using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : Singleton<ObstacleSpawner>
{
    [SerializeField] private GameObject wall;

    private List<GameObject> walls = new List<GameObject>();

    private int steps = 2;

    public void Spawn ()
    {
        walls.Add(Instantiate(wall, new Vector3(17.7f * steps, -5, 0), Quaternion.identity));
        steps++;
    }

    public void StopSpawn ()
    {
        for (int i = 0; i < walls.Count; i++)
        {
            Destroy(walls[i].gameObject);
        }
        walls.Clear();

        steps = 2;
    }
}
