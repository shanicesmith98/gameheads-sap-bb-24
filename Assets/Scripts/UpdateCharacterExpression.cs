using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class UpdateCharacterExpression : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var variableStorage = GameObject.FindObjectOfType<Yarn.Unity.InMemoryVariableStorage>();
        string npcName;
        string npcExpression;
        if (!variableStorage.TryGetValue("$npcName", out npcName))
        {
            Debug.Log("it doesn't exist");
            return;
        }
        else
        {
            Debug.Log(npcName);
            // Update character expression here
        }

        if (!variableStorage.TryGetValue("$npcExpression", out npcExpression))
        {
            Debug.Log("it doesn't exist");
            return;
        }
        else
        {
            Debug.Log(npcExpression);
            // Update character expression here
        }
    }
}
