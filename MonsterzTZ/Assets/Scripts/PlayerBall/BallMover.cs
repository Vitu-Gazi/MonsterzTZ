using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    [SerializeField] private BallSpeed ballSpeed;
    [SerializeField] private float minPositionY;
    [SerializeField] private float maxPositionY;

    private bool canMove = false;

    private void Start()
    {
        InputRegister.Instance.UpInput += MoveUp;
    }
    private void OnDestroy()
    {
        InputRegister.Instance.UpInput -= MoveUp;
    }

    private void Update()
    {
        if (!canMove)
        {
            return;
        }

        transform.position += new Vector3(ballSpeed.CurrentSpeed, 0, 0) * Time.deltaTime;
    }

    private void MoveUp(bool inputState)
    {
        Vector3 newPos = transform.position;

        if (inputState)
        {
            newPos.y += ballSpeed.CurrentUpSpeed * Time.deltaTime;
        }
        else
        {
            newPos.y -= ballSpeed.CurrentUpSpeed * Time.deltaTime;
        }

        newPos.y = Mathf.Clamp(newPos.y, minPositionY, maxPositionY);

        transform.position = newPos;
    }

    public void SetCanMove (bool value)
    {
        canMove = value;
    }
}
