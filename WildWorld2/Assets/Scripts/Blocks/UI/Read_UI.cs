using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Read_UI : Block
{
    public static Transform playerPosition;
    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;
        if (Mathf.Abs(transform.position.x - targetBlockSingle.position.x) <= 0.5f &&
                                     Mathf.Abs(transform.position.y - targetBlockSingle.position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);
            ScrollSpawn.DisplayScroll();
        }
        else
        {
            transform.position = new Vector2(playerPosition.position.x + -4.371f, playerPosition.position.y + -3.132f);
        }
    }
}

