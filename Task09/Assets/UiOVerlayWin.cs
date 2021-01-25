using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiOVerlayWin : MonoBehaviour
{
    private bool isLoading;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isLoading) { return; }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isLoading = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            isLoading = true;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
