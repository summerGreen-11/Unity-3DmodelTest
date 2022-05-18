using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RotationY : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float turnSpeed = 10f;
    private bool isBtnDown = false;
    public GameObject obj;
    private Transform trans;

    private void Start()
    {
        trans = obj.GetComponent<Transform>();
    }

    private void Update()
    {
        if (isBtnDown)
        {
            trans.Rotate(new Vector3(0, 1, 0) * turnSpeed * Time.deltaTime);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
    }
}
