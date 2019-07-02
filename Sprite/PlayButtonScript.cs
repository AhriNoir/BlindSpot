using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour
{
	// Use this for initialization
	Color c;

	void Start()
	{
		c = new Color(255, 255, 255, 255);
		GetComponent<Button>().onClick.AddListener(print);
	}

	public void print()
	{
		//Play code
		GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerScript>().SwitchEnabilityStart();
		Debug.Log("Play");
	}

}
