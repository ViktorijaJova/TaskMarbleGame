﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenePlay : MonoBehaviour
{
    private float timer;
    public Text timerText;
    public Goal goal;
    private bool hasGameEnded;
    public GameObject overlayWin;
    public GameObject overlayPause;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (hasGameEnded && Time.timeScale != 0) { return; }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            overlayPause.SetActive(true);
        }

        timer += Time.deltaTime;

        int ms = (int)(((float)(timer - (int)timer)) * 1000);
        int m = (int)timer / 60;
        int s = (int)(timer - m * 60);

        string timeString = m.ToString("D2") + ":" +  s.ToString("D2") + ":" + ms.ToString("D3");

        timerText.text = timeString;

        hasGameEnded = goal.hasBeenReached;

        if (hasGameEnded)
        {
            overlayWin.SetActive(true);
        }
    }
}

