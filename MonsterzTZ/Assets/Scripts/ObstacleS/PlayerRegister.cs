using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegister : MonoBehaviour
{
    [SerializeField] private GameObject parent;
    [SerializeField] private Transform obstacle;

    private void Start()
    {
        obstacle.localPosition = new Vector3(obstacle.localPosition.x, Random.Range(1.6f, 10), obstacle.localPosition.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out BallDeathController ball))
        {
            ObstacleSpawner.Instance.Spawn();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out BallDeathController ball) && parent != null)
        {
            Destroy(parent, 0.5f);
        }
    }
}
