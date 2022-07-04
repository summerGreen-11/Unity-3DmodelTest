using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePosition : MonoBehaviour
{
    public Slider slider;
    public Transform objectTransform;
    public Transform planeTransform;
    public Renderer planeRenderer;
    private Vector3 position1 = new Vector3(-260, 2702, 80);
    private Vector3 position2 = new Vector3(-260, 1000, 80);

    private void Start()
    {
        objectTransform.position = new Vector3(-260, 2702, 80);
        planeTransform.position = new Vector3(-249, 1702, 135);
        // Make sure the slider value is clamped between 0 and 1
        slider.onValueChanged.AddListener(UpdatePosition);
    }

    public void UpdatePosition(float value)
    {
        Vector3 newPosition = Vector3.Lerp(position1, position2, value);
        objectTransform.position = newPosition;
        planeTransform.position = new Vector3(-249, objectTransform.position.y-1000, 135);
        int planePosY = (1702-(int)(objectTransform.position.y - 1000) - 1) * 5;
        string fmt = "0000";
        string Texnum =  planePosY.ToString(fmt);
        Texture2D texture = Resources.Load<Texture2D>("Textures/"+ Texnum);
        planeRenderer.material.mainTexture = texture;
    }
}
