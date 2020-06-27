using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hello_UI : Block
{
    Transform playerPosition;
    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;

        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                             Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
            SceneManager.LoadScene("SecretaryExercise");
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                    Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
            SceneManager.LoadScene("MayandEvaExercise");
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                  Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
            SceneManager.LoadScene("FairyExercise");
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
            SceneManager.LoadScene("Greeting02Exercise");
        }
        else
        {
            transform.position = new Vector2(playerPosition.position.x + initialPosition.x, playerPosition.position.y + initialPosition.y);
        }
    }
}

