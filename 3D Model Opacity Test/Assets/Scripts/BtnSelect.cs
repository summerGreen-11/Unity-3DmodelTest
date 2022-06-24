using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnSelect : MonoBehaviour
{
    public GameObject[] maskObj;
    public GameObject[] Obj;
    public int x; //0,1 


    [SerializeField] Color[] colorArray;

    void Start()
    {
        
         maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3000;
 
    }
  
    public void SelectSkin()
    {
        if (x < 1) //x가 0인 경우
        {
            x++; //x=1
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3017;

            Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        }
        else 
        {
            //x=1이 아닌 경우
            x = 0;
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3000;

          Obj[0].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        }

    }

    public void SelectMuscle()
    {
        if (x < 1)
        {
            x++;
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3015;

            Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        }
        else
        {
            x = 0;
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3000;
            Obj[0].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        }
    
    }



    public void SelectBone()
    {
        if (x < 1)
        {
            x++;
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3013;
        Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
        Obj[1].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
        Obj[2].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);

    }
        else
        {
            x = 0;
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3000;
        Obj[0].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
         }

     }

}
