using UnityEngine;
using System.Collections;

public class WaterGive : MonoBehaviour
{
    public string orderdMeat = "Food5";

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
