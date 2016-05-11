using System.Collections;
using UnityEngine;

public class EnemyWave {
    public float Duration = 0;
    public int[] numSpawns;
    GameObject[] enemyArray;
    float[] enemyDifficulty;
    private float baseTimeBetweenSpawns = 0;

    public EnemyWave(float Difficulty, int enemyFocus, GameObject[] enemies, float[] enemyDifficulties) {
        // Store internal copies inside the wave object.
        enemyArray = enemies;
        enemyDifficulty = enemyDifficulties;

        GenerateWave(Difficulty, enemyFocus);
    }

    public GameObject spawnEnemy() {
        //return Instantiate(tempEnemy, transform.position, transform.rotation);
        return null;
    }

    void GenerateWave(float Difficulty, int enemyFocus) {

    }
}