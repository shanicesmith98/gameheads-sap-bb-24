using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingCountdownTimer : MonoBehaviour
{
    private float timer = 5f;
    [SerializeField] TextMeshProUGUI timerSeconds;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
