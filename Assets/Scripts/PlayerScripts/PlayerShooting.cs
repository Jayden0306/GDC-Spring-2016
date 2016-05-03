using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
    //Bullet
    public GameObject bullet;
    public Transform shotSpawn;

    public float shotDelay = 2f;
    float shotTimer = 0f;

    float armRotation = 0;
       

	// Update is called once per frame
    void Update () {
        SetShotAngle();
        //for the bullet instantiation
        if (Input.GetButtonDown("Fire1") && shotTimer <= 0) {
            GameObject newBullet = (GameObject)Instantiate(bullet, shotSpawn.position, Quaternion.identity);
            newBullet.transform.Rotate(0, 0, armRotation-90);
            shotTimer = shotDelay;
        }
        shotTimer -= Time.deltaTime;
	}

    void SetShotAngle() {
        RaycastHit hit;
        Ray shotRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        int layerMask = 1 << 8;

        if (Physics.Raycast(shotRay, out hit, Mathf.Infinity, layerMask)) {
            armRotation = Mathf.Atan2(hit.point.y-shotSpawn.transform.position.y, hit.point.x - shotSpawn.transform.position.x) * Mathf.Rad2Deg;
            //Debug.Log(hit.point.ToString() + " : " + armRotation);
        }
    }

}
