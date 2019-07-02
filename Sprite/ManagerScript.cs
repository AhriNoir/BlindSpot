using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

	[SerializeField] GameObject Starting;
	[SerializeField] GameObject Finishing;

	public void SwitchEnabilityStart() {
		Debug.Log("Kup");
		Debug.Log(Starting.active);
		Starting.SetActive(!Starting.active);
		Debug.Log(Starting.active);
	}
	public void SwitchEnabilityFinish() {
		Debug.Log("fbaksfn");
		Debug.Log(Finishing.active);
		Finishing.SetActive(!Finishing.active);
		Debug.Log(Finishing.active);
	}
}
