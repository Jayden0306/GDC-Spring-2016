using UnityEngine;
using System.Collections;
using System;

public class SpeedPowerupManager : AbstractPowerUp {

    public GameObject player;
    public float speedMultiplier = 1.2F;

    private PlayerMovement movement;
    private float baseMoveSpeed;
    private float poweredupSpeed;

    public void Awake()
    {
        movement = player.GetComponent<PlayerMovement>();
        baseMoveSpeed = movement.speed;
        poweredupSpeed = baseMoveSpeed * speedMultiplier;
    }

    protected override void PowerUpStart()
    {
        movement.speed = poweredupSpeed;
    }

    protected override void PowerUpEnd()
    {
        movement.speed = baseMoveSpeed;
    }
    
    protected override void PowerupUpdate() { }
}
