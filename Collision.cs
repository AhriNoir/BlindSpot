using UnityEngine;

public class Collision : MonoBehaviour {

	public Movement movement;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collisionInfo) {
		if (collisionInfo.gameObject.tag == "Player") {
			FindObjectOfType<EndScr>().Death();
		}
	}
}
