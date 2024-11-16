using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour {


    public string mousecontrolled = "n";

    void Start() {
    
    }
    void Update()
    {
        if (mousecontrolled == "y")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
            if (gameObject.name == "Musubi(Clone)")
            {
                gameplay.currentFood = "Musubi";
            }
            else
                if (gameObject.name == "Poi(Clone)")
            {
                gameplay.currentFood = "ShaveIce";
            }
            else
                if (gameObject.name == "Poke(Clone)")
            {
                gameplay.currentFood = "Poke";
            }
            else
                if (gameObject.name == "Salad(Clone)")
            {
                gameplay.currentFood = "Salad";
            }
            else
                if (gameObject.name == "Water(Clone)")
            {
                gameplay.currentFood = "Water";
            }
            else
                if (gameObject.name == "Lemonade(Clone)")
            {
                gameplay.currentFood = "Lemonade";
            }
        }

        if ((gameplay.deleteFood == "y") && (mousecontrolled == "y"))
        {
            Destroy(gameObject);
        }

    }

    void OnMouseDown()
    {
        mousecontrolled = "y";
    }
}
