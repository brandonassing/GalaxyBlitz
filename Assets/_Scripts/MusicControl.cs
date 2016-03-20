using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour
{

    /// <summary>
    /// Used to control/save sound settings
    /// </summary>

    private static MusicControl instanceRef;

    public AudioSource[] backgroundMusic;
    public Dropdown backD;
    public Slider backS;
    static float backSVal = 0;
    static int lastBackVal = 0;

    static public int laserValD = 0;
    public Dropdown laserD;
    public Slider laserS;
    static public float laserValS = 1;

    static public int expValD = 0;
    public Dropdown expD;
    public Slider expS;
    static public float expValS = 1;

    static public int winValD = 0;
    public Dropdown winD;
    public Slider winS;
    static public float winValS = 1;

    private static GameObject backgroundRef;

    void Awake()
    {
        //Lets music continue playing after new scene load
        if (instanceRef == null)
        {
            instanceRef = this;
            DontDestroyOnLoad(GameObject.Find("MusicControl"));
            DontDestroyOnLoad(backgroundMusic[0]);
            DontDestroyOnLoad(backgroundMusic[1]);
            DontDestroyOnLoad(backgroundMusic[2]);
        }
        else
        {
            DestroyImmediate(GameObject.Find("MusicControl"));
            DestroyImmediate(GameObject.Find("background1"));
            DestroyImmediate(GameObject.Find("background2"));
            DestroyImmediate(GameObject.Find("background3"));
        }

        //Sets dropdown/slider values to previous
        backD.value = lastBackVal;
        backS.value = backSVal;

        laserD.value = laserValD;
        laserS.value = laserValS;

        expD.value = expValD;
        expS.value = expValS;

        winD.value = winValD;
        winS.value = winValS;
    }

    //Plays background music
    public void PlaySongBackground()
    {
        StopLastSongBackground();
        lastBackVal = backD.value;
        backgroundMusic[backD.value].Play();
        backgroundMusic[backD.value].volume = backS.value;
    }

    //Stops previous song for song change
    public void StopLastSongBackground()
    {
        backgroundMusic[lastBackVal].Stop();
    }

    //Changes song volume and starts song if not playing
    public void ChangeSongVolumeBackground()
    {
        backSVal = backS.value;
        if (!backgroundMusic[lastBackVal].isPlaying)
        {
            backgroundMusic[lastBackVal].Play();
        }
        backgroundMusic[lastBackVal].volume = backSVal;
    }

    //Allows user to select laser sound effect
    public void SetLaserSound()
    {
        laserValD = laserD.value;
        laserValS = laserS.value;
    }
    //Allows user to select laser sound effect volume
    public void SetLaserVolume()
    {
        laserValS = laserS.value;
    }

    //Allows user to select explosion sound effect
    public void SetExplosionSound()
    {
        expValD = expD.value;
        expValS = expS.value;
    }
    //Allows user to select explosion sound effect volume
    public void SetExplosionVolume()
    {
        expValS = expS.value;
    }

    //Allows user to select level up fanfare
    public void SetWinMusic()
    {
        winValD = winD.value;
        winValS = winS.value;
    }
    //Allows user to select level up fanfare volume
    public void SetWinVolume()
    {
        winValS = winS.value;
    }


}
