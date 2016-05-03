using UnityEngine;
using System.Collections;
using System;

public class SpeedPowerup : AbstractPowerUp {

    public GameObject player;
    public GameObject target;
    public float speedMultiplier = 1.2F;


    private PlayerMovement movement;
    private float baseMoveSpeed;
    private float poweredupSpeed;

    public void Awake()
    {
        target.GetComponent<PowerupTarget>().source = this;
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

    public override void CreateTarget(Transform thePostion)
    {
        Instantiate(target, thePostion.position, thePostion.rotation);
    }
}
