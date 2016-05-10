using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGame() {
		SceneManager.LoadScene ("Main");
	}

	public void QuitGame() {
		Application.Quit();
	}
}
