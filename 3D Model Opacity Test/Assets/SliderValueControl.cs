using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueControl : MonoBehaviour
{
    public Slider sl1;
    public Slider sl2;
    public Slider sl3;

    public float maxdata = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float slvalue1 = sl1.value;
        float slvalue2 = sl2.value;
        float slvalue3 = sl3.value;

        //알고리즘 고민하기

    }
}
