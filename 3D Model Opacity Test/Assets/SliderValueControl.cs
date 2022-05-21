using UnityEngine;
using UnityEngine.UI;

public class SliderValueControl : MonoBehaviour
{
	public GameObject mySlider;
	public GameObject myToggle;
	public float maxval = 0.8f;
	public float initval = 0.79f;
	bool chk = false;
	int temp;

	// Start is called before the first frame update
	void Start()
	{


   

	}


	// Update is called once per frame
	void Update()
	{
		Slider[] sl = mySlider.GetComponentsInChildren<Slider>(true);
		Toggle[] tg = myToggle.GetComponentsInChildren<Toggle>(true);


		if (chk)
		{
			for (int k = 0; k < sl.Length; k++)
			{
				if (k != temp && sl[k].value > 0)
				{
					sl[temp].value = initval;
					tg[k].isOn = true;
				}
			}
			chk = false;
		}


		for (int k = 0; k < sl.Length; k++)
		{
			if (sl[k].value > 0) tg[k].isOn = true;
		}

		for (int i = 0; i < sl.Length; i++)
		{
			if (sl[i].value > maxval)
			{
				temp = i;
				for (int j = 0; j < sl.Length; j++)
				{
					if (j != temp)
					{
						sl[j].value = 0;
						tg[j].isOn = false;
					} 
				}
				chk = true;
			}

		}
	}
}
