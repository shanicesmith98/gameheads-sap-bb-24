using UnityEngine;
using System.Collections;

public class LemonadeGive : MonoBehaviour
{
    public string orderdMeat = "Food6";

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