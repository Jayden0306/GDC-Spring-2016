using UnityEngine;
using System.Collections;

public class MenuAndPausing : MonoBehaviour
{

    private bool isOn;
    public GameObject menu;
    public GameObject shotSpawn;
    public PlayerShooting shooting;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isOn && Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = true;
            shooting.SetCanShoot(false);
            shotSpawn.SetActive(false);
            menu.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (isOn && Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = false;
            shooting.SetCanShoot(true);
            shotSpawn.SetActive(true);
            menu.SetActive(false);
            Time.timeScale = 1.0F;
        }
    }
}
