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
            if (gameObject.name == "red(Clone)")
            {
                gameplay.currentMeat = "Food1";
            }
            else
                if (gameObject.name == "blue(Clone)")
            {
                gameplay.currentMeat = "Food2";
            }
            else
                if (gameObject.name == "green(Clone)")
            {
                gameplay.currentMeat = "Food3";
            }
            else
                if (gameObject.name == "yellow(Clone)")
            {
                gameplay.currentMeat = "Food4";
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
