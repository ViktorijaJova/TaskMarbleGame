
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMain : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
