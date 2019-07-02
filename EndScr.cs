using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScr : MonoBehaviour {

	public void Death()
	{
		GetComponent<Image>().color = new Color(255, 255, 255, 255);

	}
}
