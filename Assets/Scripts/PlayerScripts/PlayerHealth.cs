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

    public float GetHealth()
    {
        return currentHealth;
    }

    public void ReduceHealth(float damageTaken)
    {
        currentHealth -= damageTaken;
        AudioSource.PlayClipAtPoint(takeDamage, this.transform.position);
        UpdateHealthBar();

        Debug.Log(currentHealth);
    }

    public void AddHealth(float additionalHealth)
    {
        currentHealth += additionalHealth;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {

        if (currentHealth >= 0)
        {
            healthBar.transform.localScale = new Vector3(currentHealth / maxHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
        }
    }
}
