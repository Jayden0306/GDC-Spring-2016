using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static int enemyCount = 60;

    public Text playerScore;
    public Text enemiesLeft;

	// Use this for initialization
	void Awake () {
        score = 0;
        //playerScore = GetComponent<Text>();
        //enemiesLeft = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        playerScore.text = "Score: " + score;
        enemiesLeft.text = "Enemies Remaining: " + enemyCount;
	}
}
