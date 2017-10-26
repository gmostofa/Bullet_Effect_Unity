using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimeEffectScript : MonoBehaviour {

    private float slowMoTimeScale;  //slow motion time scale
    private float fastMoTimeScale;  //fast motion time scale
    private float factor = 4f;      //factor to increase or decrease the timescale by
    // Use this for initialization
    void Start()
    {
        slowMoTimeScale = Time.timeScale / factor;    //calculate the new timescale
        fastMoTimeScale = Time.timeScale * factor;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the cube at a constant rate
        transform.Rotate(new Vector3(200, 200, 200) * Time.deltaTime);
    }

    void OnGUI()
    {
        //Pause/Unpause on click
        if (GUI.Button(new Rect(0, 0, 120, 30), "PAUSE/RESUME"))
        {
            CheckPaused();
        }
        //add slow motion effect
        if (GUI.Button(new Rect(0, 30, 80, 30), "SLOWMO"))
        {
            slowMo();
        }
        //add fast motion effect
        if (GUI.Button(new Rect(0, 60, 120, 30), "FASTMO"))
        {
            fastMo();
        }
    }

    //check if paused
    void CheckPaused()
    {
        if (Time.timeScale > 0)
        {
            pauseGame();
        }
        else
        {
            unPauseGame();
        }
    }
    //pause the game
    void pauseGame()
    {
        Time.timeScale = 0;
    }
    //unpause the game
    void unPauseGame()
    {
        Time.timeScale = 1;
    }

    //add slow motion effect
    void slowMo()
    {
        //assign new time scale value
        Time.timeScale = slowMoTimeScale;
        //reduce this to the same proportion as timescale to ensure smooth simulation
        Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale;
    }

    //add fast motion effect
    void fastMo()
    {
        Time.timeScale = fastMoTimeScale;
        Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale;
    }
}
