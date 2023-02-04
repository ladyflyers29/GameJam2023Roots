using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuScreen;
    public bool play;

    // Use this for initialization
    //private void Awake()
    //{
    //    QualitySettings.vSyncCount = 0;
    //    Application.targetFrameRate = 60;
    //}
    void Start()
    {
        PauseMenuScreen.SetActive(false);
        play = true;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseControl();
        }
    }

    public void PauseControl()
    {
        if (play)
        {
            Time.timeScale = 0;
            play = false;
            PauseMenuScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        else if (!play)
        {
            Time.timeScale = 1;
            play = true;
            PauseMenuScreen.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


}
