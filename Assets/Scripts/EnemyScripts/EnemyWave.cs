using UnityEngine;
using System.Collections;

public class EnemyWave {
    public int[] numSpawns;
    GameObject[] enemyArray;
    float timeBetweenSpawns = 10;
    float currentSpawnTime = 0;
    int numEnemiesPerSpawn = 1;
    int curSpawns = 0;
    int initialNumEnemies = 10;

    public int getEnemiesRemaining() {
        int i = 0;
        foreach (int enemy in numSpawns) {
            i+=enemy;
        }
        return i;
    }

    public int totalEnemies = 0;

    public EnemyWave(int Difficulty, int enemyFocus, GameObject[] enemies) {
        // Store internal copies inside the wave object.
        enemyArray = enemies;

        GenerateWave(Difficulty, enemyFocus, 100 - Difficulty);
    }

    public GameObject spawnEnemy() {
        if (curSpawns > 0) {
            curSpawns--;
            int enemy = Random.Range(0, enemyArray.Length);
            while (numSpawns[enemy] <= 0)
                enemy = Random.Range(0, enemyArray.Length);
            numSpawns[enemy]--;

            return (GameObject)GameObject.Instantiate(enemyArray[enemy], Vector3.zero, Quaternion.identity);
        } else
        //return Instantiate(, transform.position, transform.rotation);
            return null;
    }

    void GenerateWave(int Difficulty, int enemyFocus, int focusPercent) {
        // Ratios as follows:
        //  80% focused
        //  Remained: Random between the others

        int enemyCount = totalEnemies = initialNumEnemies + Difficulty;
        numSpawns = new int[enemyArray.Length];

        if (focusPercent < 50)
            focusPercent = 50;

        while (enemyCount > 0) {
            for (int i = 0; i < enemyArray.Length; i++) {
                float Percent = Random.Range(0.0f, 100f);
                if (Percent <= focusPercent && i == enemyFocus) {
                    numSpawns[i]++;
                    enemyCount--;
                } else if (Percent > focusPercent && i != enemyFocus) {
                    numSpawns[i]++;
                    enemyCount--;
                }
            }
        }

        numEnemiesPerSpawn = 1 + (int)(Difficulty / 3);

        timeBetweenSpawns = 5 - (0.2f * Difficulty);
        if (timeBetweenSpawns < 2) {
            timeBetweenSpawns = 2;
        }
        if (numEnemiesPerSpawn > 3) {
            timeBetweenSpawns -= (numEnemiesPerSpawn - 3) * .05f;
            numEnemiesPerSpawn = 3;
        }
        //Debug.Log(Difficulty.ToString() + ":" + timeBetweenSpawns.ToString());
    }

    public bool Update() {
        currentSpawnTime -= Time.deltaTime;
        if (currentSpawnTime <= 0) {
            currentSpawnTime = timeBetweenSpawns;
            curSpawns = numEnemiesPerSpawn;
            if (curSpawns > getEnemiesRemaining())
                curSpawns = getEnemiesRemaining();
        }
        if (getEnemiesRemaining() == 0)
            return false;
        else
            return true;
    }
}