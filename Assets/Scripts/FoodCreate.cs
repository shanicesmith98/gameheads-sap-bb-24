using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreate : MonoBehaviour
{

    public Transform LemonadeObj;
    public Transform PoiObj;
    public Transform MusubiObj;
    public Transform PokeObj;
    public Transform SaladObj;
    public Transform WaterObj;

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
        if (gameObject.name == "Musubi_Maker")
        { 
            Instantiate(MusubiObj, new Vector3(-7, 0.6f), MusubiObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);
        }
        else
            if (gameObject.name == "Poke_Maker")
        {
            Instantiate(PokeObj, new Vector3(-8, -0.08f), PokeObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }
        else
            if (gameObject.name == "Poi_Maker")
        {
            Instantiate(PoiObj, new Vector3(-6, 1.1f), PoiObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }
        else
            if (gameObject.name == "Lemonade_Maker")
        {
            Instantiate(LemonadeObj, new Vector3(-6, 1f), LemonadeObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }
        else
            if (gameObject.name == "Water_Maker")
        {
            Instantiate(WaterObj, new Vector3(-6, 0.6f), WaterObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }
        else
            if (gameObject.name == "Salad_Maker")
        {
            Instantiate(SaladObj, new Vector3(-7, 1.3f), SaladObj.rotation);
            Instantiate(FoodAni, new Vector3(-9, 6f), FoodAni.rotation);

        }

    }
}