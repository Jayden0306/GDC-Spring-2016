using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour {

	public void StartGame(string sceneName) {
		SceneManager.LoadScene (sceneName);
	}

	public void QuitGame() {
		Application.Quit();
	}
}
