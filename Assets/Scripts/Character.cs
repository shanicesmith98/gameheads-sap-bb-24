using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Character : MonoBehaviour {
    [System.Serializable] // map of textures for facial expressions
    public class Expression {
        public string name;
        public Sprite spriteExpression;
    }

    // objects needed to render new textures on Character face
    [SerializeField] List<Expression> expressions = new List<Expression>();
    [SerializeField] Renderer faceRenderer;
    [SerializeField] int faceMaterialIndex;

    // when this character is first created
    public void Awake() {
        // set initial pose and facial expression to defaults
        if (expressions.Count < 1) {
            Debug.LogError($"Character {name} has no available facial textures.");
            return;
        }
        SetFaceExpression(expressions[0].spriteExpression);
        Debug.Log($"Character {name} created.");
    }

    // sets character expression texture to {expressionName} texture
    [YarnCommand("expression")]
    public void SetExpression(string expressionName){
        // find the expression with the same name as we are looking for
        Expression expressionToUse = FindExpressionWithName(expressionName);
        if (expressionToUse == null) {
            Debug.LogError($"Character {name} has no Expression named {expressionName}.");
            return;
        }
        SetFaceExpression(expressionToUse.spriteExpression);
    }

    private Expression FindExpressionWithName(string expressionName) {
        var caseInsensitiveMode = System.StringComparison.InvariantCultureIgnoreCase;
        foreach (Expression expression in expressions) {
            if (expression.name.Equals(expressionName, caseInsensitiveMode)) {
                return expression;
            }
        }
        return null;
    }

    private void SetFaceExpression(Sprite sprite) {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
