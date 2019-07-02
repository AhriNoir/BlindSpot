using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour {


	public void Death()
	{
		transform.position = new Vector3(x: 0, y: 0, z: transform.position.z);
	
	}
}
