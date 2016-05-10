using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    private float maxHealth = 100f;
    private float currentHealth = 0f;

    public AudioClip takeDamage;
    public GameObject healthBar;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}

    public void ReduceHealth(float damageTaken)
    {
        currentHealth -= damageTaken;
        AudioSource.PlayClipAtPoint(takeDamage, this.transform.position);
        if (currentHealth >= 0)
        {
            healthBar.transform.localScale = new Vector3(currentHealth / maxHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
        }
        Debug.Log(currentHealth);
    }
}
