using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        Vector3 pos = new Vector3(target.position.x + offset.x, 0, target.position.z + offset.z);

        transform.position = Vector3.Lerp(transform.position, pos, speed);
    }

    public void SetTarget (Transform newTarget)
    {
        target = newTarget;
    }
}
