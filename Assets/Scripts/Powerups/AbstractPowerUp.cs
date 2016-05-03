using UnityEngine;
using System.Collections;

public abstract class AbstractPowerUp : MonoBehaviour {

    public int durration;

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
	void Update () {
	    if (activated && endTime < Time.time)
        {
            activated = false;
            PowerUpEnd();
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

        }
    }

    public bool IsActivated()
    {
        return activated;
    }

    //Create the target we will aim at to activate the powerup at the given position
    public abstract void CreateTarget(Transform thePostion);

    //Run when the powerup initially starts
    protected abstract void PowerUpStart();

    //Run when the powerup ends for cleanup
    protected abstract void PowerUpEnd();
}
