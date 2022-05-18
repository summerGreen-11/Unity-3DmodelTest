using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateAround : MonoBehaviour
{
    public GameObject stage;

    private float xRotateMove, yRotateMove;

    public float rotateSpeed = 500.0f;

    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButton(0))
            {
                xRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

                Vector3 stagePosition = stage.transform.position;

                transform.RotateAround(stagePosition, Vector3.up, xRotateMove);

                transform.LookAt(stagePosition);
            }
        }
    }
}