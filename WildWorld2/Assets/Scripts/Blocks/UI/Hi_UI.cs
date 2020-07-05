
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hi_UI : Block
{
    public static Transform playerPosition;
    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;
        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
            EvaDialogue.DisplayDialogue();
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
            MayDialogue.DisplayDialogue();
        }
        else
        {
            transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -3.120f);
        }
    }
}

