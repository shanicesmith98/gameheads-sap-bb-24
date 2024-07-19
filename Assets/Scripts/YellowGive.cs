using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowGive : MonoBehaviour
{
    public string orderdMeat = "Food4";

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
        if ((gameplay.deleteFood == "y") && (gameplay.currentMeat == orderdMeat))
        {
            Destroy(gameObject);
        }
    }
}
