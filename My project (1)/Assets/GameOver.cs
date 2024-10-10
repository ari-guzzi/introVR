using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
private bool winner = false;
public GameObject[] targets;
private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Damage") {
	      string currentSceneName = SceneManager.GetActiveScene().name;
	      SceneManager.LoadScene(currentSceneName);
	  }
}

public void Update() {
	targets = GameObject.FindGameObjectsWithTag("target");

	if (targets.Length < 1) {
		SceneManager.LoadScene("WinScene");
	}
}
	// public void decreaseTargets(){
	// 	targets--;
	// 	checkIfWin();
	// }
// private void checkIfWin() {
// 		if (targets <= 0)
//         {
// 			winner = true;
// 			SceneManager.LoadScene("Assets/StartScene");
// 		}
// }

}
