using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingTransition : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(2); // Gameplay scene/Click n Drag
    }
}
