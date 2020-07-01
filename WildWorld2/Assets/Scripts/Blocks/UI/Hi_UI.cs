
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
        transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
    }
}

