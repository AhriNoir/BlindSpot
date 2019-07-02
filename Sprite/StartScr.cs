using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScr : MonoBehaviour
{
	Color c;
	private void Start()
	{
		c = new Color(255, 255, 255, 255);
		GetComponent<Image>().color = c;
	}

	public void Play()
	{
		GetComponent<Image>().color = new Color(255, 255, 255, 0);

	}
}
