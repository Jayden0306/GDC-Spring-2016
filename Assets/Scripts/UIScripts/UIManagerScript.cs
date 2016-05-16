using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour {

	public void StartGame(string sceneName) {
        Time.timeScale = 1f;
		SceneManager.LoadScene (sceneName);
	}

	public void QuitGame() {
		Application.Quit();
	}
}
