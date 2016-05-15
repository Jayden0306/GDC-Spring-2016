using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int publicEnemyCount;

    private int score;
    private int enemyCount;

    public Text playerScore;
    public Text enemiesLeft;

	// Use this for initialization
	void Awake () {
        //enemyCount = publicEnemyCount;
        score = 0;
        SetScore(score);
        SetEnemyCount(enemyCount);
	}

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int theScore)
    {
        score = theScore;
        playerScore.text = "Score: " + score;
    }

    public void AddScore(int theScore)
    {
        score += theScore;
        playerScore.text = "Score: " + score;
    }

    public void SetEnemyCount(int theEnemyCount)
    {
        enemyCount = theEnemyCount;
        enemiesLeft.text = "Enemies Remaining: " + enemyCount;
    }

    public void AddEnemyCount(int theCount)
    {
        enemyCount += theCount;
        enemiesLeft.text = "Enemies Remaining: " + enemyCount;
    }
}
