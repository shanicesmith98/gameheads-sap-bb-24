using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{

    public static string deleteFood = "n";
    public static string currentFood;

    internal static readonly int selectedSlot=0;
    public static int selectedItem=0;

    public KeyCode giveFood;

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(giveFood))
        {
            deleteFood = "y";
        }
        else
        {
            deleteFood = "n";
        }
    }
}
