using UnityEngine;

public class GameManager : MonoBehaviour
{

	bool gameHasEnded = false;

	public void EndGame()
	{
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			FindObjectOfType<EndScreen>().Death();

		}
	}
}
