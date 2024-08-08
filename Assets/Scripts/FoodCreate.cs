using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreate : MonoBehaviour
{

    public Transform GreenObj;
    public Transform BlueObj;
    public Transform RedObj;
    public Transform YellowObj;

    public Transform FoodAni;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject.name == "SpamMusubi_RedMaker")
        { 
            Instantiate(RedObj, new Vector3(-18, -2.7f), RedObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);
        }
        else
            if (gameObject.name == "Poke_YellowMaker")
        {
            Instantiate(YellowObj, new Vector3(-18, -2.7f), YellowObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }
        else
            if (gameObject.name == "Poi_BlueMaker")
        {
            Instantiate(BlueObj, new Vector3(-18, -2.7f), BlueObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }
        else
            if (gameObject.name == "Lemonade_GreenMaker")
        {
            Instantiate(GreenObj, new Vector3(-18, -2.7f), GreenObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }

    }
}