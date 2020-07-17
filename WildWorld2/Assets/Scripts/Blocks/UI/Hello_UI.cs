using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hello_UI : Block
{
    public static bool suelocked;
    public static Transform playerPosition, cardPosition;

    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;
        cardPosition = this.transform;

        //Academy --------------------------------------
        if (sceneName == "Academy")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
                SecretaryDialogue.DisplayDialogue();
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                SueDialogue.DisplayDialogue();
                suelocked = true;

            }
            else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                       Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                SuePlayerDialogue.answer++;
                suelocked = true;
            }
            else
            {
                for (int i = 0; i < targetBlocks.Length; i++)
                {
                    if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                              Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                        Progress.emotion++;
                }

                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
            }
        }

        // Ouside Academy --------------------------------------
        if (sceneName == "Outside Academy")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                if (!Progress.door)
                    FairyDialogue.DisplayDialogue();
                else
                    FairyDialogue.DisplayDialogue2();

            }
            if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                           Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                FairyPlayerDialogue.answer = true;
                locked = true;
            }
            else
            {
                for (int i = 0; i < targetBlocks.Length; i++)
                {
                    if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                              Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                        Progress.emotion++;
                }

                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
            }
        }
    }
    public static void ReturnToInitialPosition()
    {
        locked = false;
        suelocked = false;
        cardPosition.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
    }

    protected override void Update()
    {
        if (sceneName == "Outside Academy")
        {
            if (locked)
            {
                transform.position = new Vector2(-3.907827f, 3.307083f);
            }
        }
        if (sceneName == "Academy")
        {
            if (suelocked & SuePlayerDialogue.answer == 0)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
            }
            else if (suelocked)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
            }
        }
    }
}

