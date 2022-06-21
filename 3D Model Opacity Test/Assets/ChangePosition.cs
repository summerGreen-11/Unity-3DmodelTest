using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePosition : MonoBehaviour
{
    public Slider slider;
    public Transform objectTransform;
    private Vector3 position1 = new Vector3(0, -1828, 0);
    private Vector3 position2 = new Vector3(0, 50, 0);

    private void Start()
    {
        objectTransform.position = new Vector3(0, -1828, 0);
        // Make sure the slider value is clamped between 0 and 1
        slider.onValueChanged.AddListener(UpdatePosition);
    }

    public void UpdatePosition(float value)
    {
        Vector3 newPosition = Vector3.Lerp(position1, position2, value);
        objectTransform.position = newPosition;
    }
}
