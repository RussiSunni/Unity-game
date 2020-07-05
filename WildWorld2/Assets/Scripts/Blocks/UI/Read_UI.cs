using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Read_UI : Block
{
    public static Transform playerPosition;
    bool readLocked;

    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;
        if (Mathf.Abs(transform.position.x - targetBlockSingle.position.x) <= 0.5f &&
                                     Mathf.Abs(transform.position.y - targetBlockSingle.position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);

            if (ScrollSpawn.scroll.activeSelf)
            {
                readLocked = false;
                transform.position = new Vector2(playerPosition.position.x + -4.371f, playerPosition.position.y + -3.132f);
                ScrollSpawn.HideScroll();
            }

            else if (readLocked == false)
            {
                readLocked = true;
                ScrollSpawn.DisplayScroll();
            }
        }
        else
        {
            transform.position = new Vector2(playerPosition.position.x + -4.371f, playerPosition.position.y + -3.132f);
        }
    }

    protected override void Update()
    {
        if (readLocked)
        {
            transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);
        }
    }
}

