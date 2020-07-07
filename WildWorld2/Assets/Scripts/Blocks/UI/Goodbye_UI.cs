using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goodbye_UI : Block
{
    public static Transform playerPosition, cardPosition;
    public static bool goodbyeLocked;
    protected override void OnMouseUp()
    {
        cardPosition = this.transform;
        playerPosition = GameObject.Find("Player").transform;
        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
        }
        else
        {
            transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -3.132f);
        }
    }

}

