using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

    public GameObject[] enemy;
    public float minSpawnTime;
    public float maxSpawnTime;
    public int enemyCount;
    public GameObject gameManager;
    //public Transform spawn;

    private ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
        StartCoroutine (Spawn());
        scoreManager = gameManager.GetComponent<ScoreManager>();
        enemyCount = scoreManager.publicEnemyCount / 3;
        //InvokeRepeating("Spawn", spawnTime, Random.Range(2, 6));
	}
	
    IEnumerator Spawn () {
        yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            for (int i = enemyCount; i > 0; i--) {
                // this line will choose a random enemy from the enemy array.
                GameObject tempEnemy = enemy[Random.Range(0, enemy.Length)];
                
                // Work around, setting the game manager for the enemies...
                tempEnemy.GetComponent<EnemyCollision>().gameManager = gameManager;

                Instantiate(tempEnemy, transform.position, transform.rotation);
                yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            }   
    }
}
