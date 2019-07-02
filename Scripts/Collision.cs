using UnityEngine;

public class Collision : MonoBehaviour {

	public Movement movement;


	void OnTriggerEnter2D(Collider2D collisionInfo) {
		if (collisionInfo.gameObject.tag == "Player") {
			Debug.Log("adadadaa");
			GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerScript>().SwitchEnabilityFinish();
		}
	}
}
