using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{

    //public GameObject overlayWin;
    private bool _hasBeenReached;
    public bool hasBeenReached
    {
        get
        {
            return _hasBeenReached;
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.CompareTag("Player"))
        {
            //SceneManager.LoadScene("Main");
            //overlayWin.SetActive(true);
            _hasBeenReached = true;
        }
    }
}

