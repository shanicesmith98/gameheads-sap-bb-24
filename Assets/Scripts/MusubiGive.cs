using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusubiGive : MonoBehaviour
{
    public string orderdMeat = "Food1";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if ((gameplay.deleteFood == "y") && (gameplay.currentFood == orderdMeat))
        {
            ChangeCharacter.currentCustomer = ChangeCharacter.currentCustomer + 1;

        }
    }
}
