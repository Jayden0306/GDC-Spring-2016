using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int publicEnemyCount;

    public static int score;
    public static int enemyCount;

    public Text playerScore;
    public Text enemiesLeft;

	// Use this for initialization
	void Awake () {
        enemyCount = publicEnemyCount;
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
