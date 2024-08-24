using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene("OpeningMontage");
    }

    public void OnOpeningContinueButton ()
    {
         SceneManager.LoadScene("LoadingScene");
    }

    public void OnQuitButton ()
    {
        SceneManager.LoadScene("EndingMontage");
    }

    public void OnEndingContinueButton ()
    {
         SceneManager.LoadScene("Credits");
    }

}
