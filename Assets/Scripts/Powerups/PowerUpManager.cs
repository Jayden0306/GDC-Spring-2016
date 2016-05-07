using UnityEngine;
using System.Collections;

public class PowerUpManager : MonoBehaviour {

    public GameObject[] possiblePowerups;

    // a number between 0 and 1 for likeliness of powerup spawning on enemy death
    public float powerupFrequency;

    private AbstractPowerUp[] powerups;

	// Use this for initialization
	void Awake () {
        powerups = new AbstractPowerUp[possiblePowerups.Length];

        for (int i = 0; i < possiblePowerups.Length; i++)
        {
            powerups[i] = possiblePowerups[i].GetComponent<AbstractPowerUp>();
        }

    }

    public void EnemyDeath(Transform location)
    {
        if (Random.value < powerupFrequency)
        {
            int choice = Random.Range(0, powerups.Length);
            powerups[choice].CreateTarget(location);
        }
    }

    
}
