﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class AbstractPowerUp : MonoBehaviour {

    public GameObject image;

    public int durration;
    public GameObject targetTrigger;

    // the time when the current powerup ends
    private float endTime;

    //if the powerup is activated
    private bool activated;


	// Use this for initialization
	void Awake () {
        endTime = Time.time;
        activated = false;
	}
	
	// Update is called once per frame
	protected void Update () {
	    if (activated)
        {
            if (endTime < Time.time) {
                activated = false;
                PowerUpEnd();
            } else
            {
                PowerupUpdate();
            }
        } 
	}

    //Activate the powerup
    public void ActivatePowerUp()
    {
        if (activated)
        {
            endTime += durration;
        }
        else
        {
            activated = true;
            endTime = Time.time + durration;
            PowerUpStart();
            image.GetComponent<Image>().sprite = targetTrigger.GetComponentInChildren<SpriteRenderer>().sprite;
            image.SetActive(IsActivated());
        }
    }

    public float GetTimeLeft()
    {
        return endTime - Time.time;
    }

    public bool IsActivated()
    {
        return activated;
    }
    
    public void CreateTarget(Transform thePostion)
    {
        targetTrigger.GetComponent<PowerupTarget>().source = this;
        Instantiate(targetTrigger, thePostion.position + Vector3.up * thePostion.localScale.y, thePostion.rotation);
    }

    //Updates when the powerup is running
    protected abstract void PowerupUpdate();

    //Run when the powerup initially starts
    protected abstract void PowerUpStart();

    //Run when the powerup ends for cleanup
    protected abstract void PowerUpEnd();
}
