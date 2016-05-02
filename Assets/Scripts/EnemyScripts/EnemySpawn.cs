using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

    public GameObject[] enemy;
    public float minSpawnTime;
    public float maxSpawnTime;
    public int enemyCount;
    //public Transform spawn;

	// Use this for initialization
	void Start () {
        StartCoroutine (Spawn());
        enemyCount = ScoreManager.enemyCount / 3;
        //InvokeRepeating("Spawn", spawnTime, Random.Range(2, 6));
	}
	
    IEnumerator Spawn () {
        yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            for (int i = enemyCount; i > 0; i--) {
                // this line will choose a random enemy from the enemy array.
                GameObject tempEnemy = enemy[Random.Range(0, enemy.Length)];
                Instantiate(tempEnemy, transform.position, transform.rotation);
                yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            }   
    }
}
