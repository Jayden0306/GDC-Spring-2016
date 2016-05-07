using UnityEngine;
using System.Collections;

public class PowerupTarget : MonoBehaviour {

    public float destroyDelay = 3f;
    public AbstractPowerUp source;


    public void Awake()
    {
        Destroy(this.gameObject, destroyDelay);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            source.ActivatePowerUp();
            Destroy(this.gameObject);
        }
    }
}
