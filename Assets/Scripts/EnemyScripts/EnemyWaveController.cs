using UnityEngine;
using System.Collections;

public class EnemyWaveController : MonoBehaviour {
    private Vector3[] spawnLocations;
    private float internalTimer = 0f;

    public GameObject[] enemyArray;
    [Tooltip("This array should be the same size as enemyArray. Each value corresponds to an enemy in the enemyArray, and is the number of seconds expected to take to kill it.")]
    public float[] enemyDifficulty;
    public int startingDifficulty = 0;

    private EnemyWave activeWave;


    void Awake() {
        // Grab all our children for spawn locations
        spawnLocations = new Vector3[transform.childCount];
        int i = 0;
        foreach (Transform child in transform) {
            spawnLocations[i] = child.position;
            // Debug.Log(spawnLocations[i].ToString());
            i++;
        }
    }

    void Update() {

    }
}
