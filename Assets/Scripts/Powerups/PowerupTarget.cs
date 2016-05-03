using UnityEngine;
using System.Collections;

public class PowerupTarget : MonoBehaviour {

    public AbstractPowerUp source;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            source.ActivatePowerUp();
            Destroy(this.gameObject);
        }
    }
}
