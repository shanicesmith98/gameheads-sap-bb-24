using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(4);
        Object.Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        Object.Destroy(this.gameObject);
    }
}
