using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTransparent : MonoBehaviour
{
    public GameObject currentGameObject;
    public float alpha = 0.2f; //half transparency
    //Get current Material
    private Material currentMat;

    void Start()
    {
        currentGameObject = gameObject;
        currentMat = currentGameObject.GetComponent<Renderer>().material;
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }

    public void ChangeAlphaOnValueChange(Slider slider)
	{
        ChangeAlpha(currentMat, slider.value);
	}
}
