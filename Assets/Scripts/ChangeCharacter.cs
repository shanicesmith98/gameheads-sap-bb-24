using UnityEngine;
using System.Collections;

public class ChangeCharacter : MonoBehaviour
{
   public GameObject[] character = new GameObject [4];

    public static int currentCustomer = 0;

    void Start()
    {
        character[0].SetActive(true);
    }

    void Update()
    {
       if(currentCustomer == 0)
       {
            character[0].SetActive(true);
            character[1].SetActive(false);
            character[2].SetActive(false);
            character[3].SetActive(false);
        }
       else
            if(currentCustomer == 1)
        {
            character[0].SetActive(false);
            character[1].SetActive(true);
            character[2].SetActive(false);
            character[3].SetActive(false);
        }
        else
            if (currentCustomer == 2)
        {
            character[0].SetActive(false);
            character[1].SetActive(false);
            character[2].SetActive(true);
            character[3].SetActive(false);
        }
        else
            if (currentCustomer == 3)
        {
            character[0].SetActive(false);
            character[1].SetActive(false);
            character[2].SetActive(false);
            character[3].SetActive(true);
        }
       else
        {
            character[0].SetActive(false);
            character[1].SetActive(false);
            character[2].SetActive(false);
            character[3].SetActive(false);
        }
    }
}
