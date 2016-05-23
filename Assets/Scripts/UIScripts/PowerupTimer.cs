using UnityEngine;
using System.Collections;

public class PowerupTimer : MonoBehaviour {

    public GameObject myTimerBar;

    private Sprite myImage;
    private float myStartTime;
    private float myTime;

	public PowerupTimer (Sprite image, float time)
    {
        myImage = image;
        myStartTime = time;
        myTime = myStartTime;
        scaleImage();
    }

    public void reduceTime (float reduction)
    {
        myTime -= reduction;
        scaleImage();
    }

    void scaleImage ()
    {
        myTimerBar.transform.localScale = new Vector3(myTime / myStartTime, myTimerBar.transform.localScale.y, myTimerBar.transform.localScale.z); ;
    }
}
