using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnSelect : MonoBehaviour
{
    public GameObject[] maskObj;
    public GameObject[] Obj;
    public int x; //0,1 

    public Text OnOffTxt;


    [SerializeField] Color[] colorArray;

    void Start()
    {
        
         maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3000;

 
    }

    void Update()
    {
        if(x==0)
            OnOffTxt.text = "All";
        else
            OnOffTxt.text = "Each";
    }

    public void SelectSkin()
    {
        if (x < 1) //x?? 0?? ????
        {
            x++; //x=1
            maskObj[x].GetComponent<MeshRenderer>().material.renderQueue = 3017;

          
            Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
        }
        else 
        {
            //x=1?? ???? ????
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
