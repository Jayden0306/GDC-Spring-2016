using UnityEngine;
using UnityEngine.UI;

public class MenuAndPausing : MonoBehaviour
{

    private bool isOn;
    private bool canUse;

    public GameObject menu;
    public GameObject waveText;
    public GameObject shotSpawn;

    public Text menuText;

    public PlayerShooting shooting;

    // Use this for initialization
    void Start()
    {
        isOn = false;
        canUse = true;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (canUse && !isOn && Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = true;
            shooting.SetCanShoot(false);
            shotSpawn.SetActive(false);
            menu.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (canUse && isOn && Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = false;
            shooting.SetCanShoot(true);
            shotSpawn.SetActive(true);
            menu.SetActive(false);
            Time.timeScale = 1.0F;
        }
    }

    public void GameOver()
    {
        canUse = false;
        waveText.SetActive(false);
        shooting.SetCanShoot(false);
        shotSpawn.SetActive(false);
        menu.SetActive(true);
        menuText.text = "Game Over";
        Time.timeScale = 0f;
    }
}
