using UnityEngine;
using System.Collections;
using System;

public class HealthPowerup : AbstractPowerUp
{
    public GameObject gameManager;
    public float healthToAdd = 10f;

    private PlayerHealth health;

    public void Awake()
    {
        health = gameManager.GetComponent<PlayerHealth>();
    }

    protected override void PowerupUpdate()
    {
        health.AddHealth((healthToAdd * Time.deltaTime) / durration);
    }

    protected override void PowerUpStart() { }

    protected override void PowerUpEnd() {
        image.SetActive(IsActivated());
    }
}
