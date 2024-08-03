using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        // TODO: Add progress bar to the loading screen
        // SceneManager.LoadScene("LoadingScene");
        SceneManager.LoadScene(2);
    }

}
