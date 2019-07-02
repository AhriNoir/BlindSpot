using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButtonScript : MonoBehaviour
{

	// Use this for initialization
	Color c;

	void Start()
	{
		c = new Color(255, 255, 255, 255);
		GetComponent<Button>().onClick.AddListener(print);
	}

	// Update is called once per frame
	void Update()
	{

		if (transform.parent.GetComponent<Image>().color == c)
		{
			this.GetComponent<Button>().interactable = true;
		}
		else
		{
			this.GetComponent<Button>().interactable = false;
		}

	}
	public void print()
	{
		//Restart code
		Debug.Log("Restart");
	}

}