using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class EnemyWaveController : MonoBehaviour {
    private Vector3[] spawnLocations;
    public float TimeBetweenWaves = 10f;
    private float internalTimer = 0f;

    public GameObject[] enemyArray;
    public int startingDifficulty = 0;
    [Tooltip("This array controls what the pattern of focused spawns is (i.e. 0 0 1 1 2 2 would result in enemy 0 being the focus for 2 waves, then enemy 1 for 2 ...")]
    public int[] FocusPattern;
    private int currentFocus;

    public GameObject gameManager;
    private ScoreManager enemyCount;

    private AudioSource waveStart;

    private int currentDifficulty = 0;

    private EnemyWave activeWave;

    public Text waveText;
    private int waveCounter = 0;


    void Awake() {
        enemyCount = gameManager.GetComponent<ScoreManager>();
        waveStart = gameManager.GetComponent<AudioSource>();
        // Grab all our children for spawn locations
        spawnLocations = new Vector3[transform.childCount];
        int i = 0;
        foreach (Transform child in transform) {
            spawnLocations[i] = child.position;
            // Debug.Log(spawnLocations[i].ToString());
            i++;
        }
        if (currentFocus < 0)
            currentFocus = 0;
        if (FocusPattern.Length == 0) {
            Debug.LogError("Focus Pattern is 0 length, cannot spawn enemies.");
            Destroy(this);
        }
        currentDifficulty = startingDifficulty;
    }

    void Update() {
        internalTimer -= Time.deltaTime;
        if (internalTimer <= 0f) {
            if (activeWave == null) {
                waveStart.PlayDelayed(0f);
                activeWave = new EnemyWave(currentDifficulty, FocusPattern[currentFocus], enemyArray);
                waveCounter++;
                waveText.text = "WAVE " + waveCounter.ToString();
                waveText.GetComponent<Animation>().Play();
            }  else {
                GameObject newEnemy = activeWave.spawnEnemy();
                int[] spawnedAt = new int[3];
                for (int i = 0; i < spawnedAt.Length; i++)
                    spawnedAt[i] = -1;
                int curSpawn = 0;
                while (newEnemy != null) {
                    int newSpawn = -1;
                    while (Array.IndexOf(spawnedAt, newSpawn) != -1) {
                        newSpawn = UnityEngine.Random.Range(0, spawnLocations.Length);
                    }
                    spawnedAt[curSpawn] = newSpawn;
                    newEnemy.transform.position = spawnLocations[spawnedAt[curSpawn]];
                    newEnemy = activeWave.spawnEnemy();
                    curSpawn++;
                }
            }
            if (!(activeWave.Update())) {
                activeWave = null;
                internalTimer = TimeBetweenWaves;
                currentDifficulty++;
                currentFocus++;
                if (currentFocus >= FocusPattern.Length)
                    currentFocus = 0;
            }
    
        }

        enemyCount.SetEnemyCount(GetEnemiesRemaining());
    }

    public int GetEnemiesRemaining() {
        if (activeWave != null)
            return activeWave.getEnemiesRemaining();
        else
            return 0;
    }

    public int GetTotalEnemies() {
        if (activeWave != null)
            return activeWave.totalEnemies;
        else
            return 0;
    }
}