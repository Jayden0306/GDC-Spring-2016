using UnityEngine;
using System.Collections;

public class MenuAndPausing : MonoBehaviour
{

    private bool isOn;
    public GameObject menu;
    public GameObject waveText;
    public GameObject shotSpawn;
    public PlayerShooting shooting;

    // Use this for initialization
    void Start()
    {
        isOn = false;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOn && Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = true;
            waveText.SetActive(false);
            shooting.SetCanShoot(false);
            shotSpawn.SetActive(false);
            menu.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (isOn && Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = false;
            waveText.SetActive(true);
            shooting.SetCanShoot(true);
            shotSpawn.SetActive(true);
            menu.SetActive(false);
            Time.timeScale = 1.0F;
        }
    }

}
