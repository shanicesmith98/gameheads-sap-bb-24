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
                gameplay.currentMeat = "Food1";
            }
            else
                if (gameObject.name == "Poi(Clone)")
            {
                gameplay.currentMeat = "Food2";
            }
            else
                if (gameObject.name == "Poke(Clone)")
            {
                gameplay.currentMeat = "Food3";
            }
            else
                if (gameObject.name == "Salad(Clone)")
            {
                gameplay.currentMeat = "Food4";
            }
            else
                if (gameObject.name == "Water(Clone)")
            {
                gameplay.currentMeat = "Food5";
            }
            else
                if (gameObject.name == "Lemonade(Clone)")
            {
                gameplay.currentMeat = "Food6";
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
