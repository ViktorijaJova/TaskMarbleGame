using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiOverleyPause : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
}
