using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityTest : MonoBehaviour
{
    Renderer Orenderer;
    public GameObject target;
    public float opacityValue = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Orenderer = target.GetComponent<Renderer>();
        Debug.Log("START");
    }

    void FadeOut()
    {
        Color c = Orenderer.material.color;
        c.a = opacityValue;
        Orenderer.material.color = c;
        opacityValue -= 0.1f;
    }

    void FadeIn()
    {
        Color c = Orenderer.material.color;
        c.a = opacityValue;
        Orenderer.material.color = c;
        opacityValue += 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        // FadeOut
        if (Input.GetKeyDown("q"))
        {
            FadeOut();
        }

        // FadeIn
        if (Input.GetKeyDown("w"))
        {
            FadeIn();
        }
    }
}
