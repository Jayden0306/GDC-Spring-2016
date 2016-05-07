using UnityEngine;
using System.Collections;
using System;

public class ReloadSpeedPowerupManager : AbstractPowerUp
{
    public GameObject player;
    public float reloadMultiplier = 0.5F;

    private PlayerShooting playerShooting;
    private float baseReloadTime;
    private float poweredupReloadTime;

    public void Awake()
    {
        playerShooting = player.GetComponent<PlayerShooting>();
        baseReloadTime = playerShooting.shotDelay;
        poweredupReloadTime = baseReloadTime * reloadMultiplier;
    }

    protected override void PowerUpStart()
    {
        playerShooting.shotDelay = poweredupReloadTime;
    }

    protected override void PowerUpEnd()
    {
        playerShooting.shotDelay = baseReloadTime;
    }
}
