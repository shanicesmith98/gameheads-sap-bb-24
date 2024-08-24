using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateEndingMontage : MonoBehaviour
{
    public GameObject[] Panel = new GameObject [4];
    public static int currentPanel = 0;

    void Start()
    {
        Panel[currentPanel].SetActive(true);
    }

    public void OnEndingNextButton()
    {
        if (currentPanel > Panel.Length - 1) {
            Destroy(GameObject.FindWithTag("Destroy"));
        }
        else {
            currentPanel++;
        }
        Panel[currentPanel - 1].SetActive(false);
    }

}
