using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class O : MonoBehaviour
{
    Transform[] targetBlock = new Transform[4];
    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;

    public static bool pressed;

    public static bool reset;

    public static bool destroyed;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

        locked = false;

        targetBlock[0] = GameObject.Find("target_block-1").transform;
        targetBlock[1] = GameObject.Find("target_block-2").transform;
        targetBlock[2] = GameObject.Find("target_block-3").transform;
        targetBlock[3] = GameObject.Find("target_block-4").transform;
    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
            pressed = true;
        }

        if (TestExerciseNext.catFlag && TestExerciseNext.owlFlag == false || TestExerciseNext.bearFlag && TestExerciseNext.wolfFlag == false)
        {
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy02;
        }
        else
        {
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
        }

    }
    private void OnMouseUp()
    {
        pressed = false;
        //DOG
        if (TestExerciseNext.catFlag && TestExerciseNext.dogFlag == false)
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy04;
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                locked = true;
                SoundManagerScript.playCorrectSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy03;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }
        //OWL
        else if (TestExerciseNext.dogFlag && TestExerciseNext.owlFlag == false)
        {
            if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy04;
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                pressed = false;
                locked = true;
                SoundManagerScript.playCorrectSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy03;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }
        // WOLF
        else if (TestExerciseNext.bearFlag && TestExerciseNext.wolfFlag == false)
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f ||
                Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
               Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy04;
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                pressed = false;
                locked = true;
                SoundManagerScript.playCorrectSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy03;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }
        else
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                                 Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                                 Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f ||
                                  Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy04;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }
    }

    void Update()
    {
        if (reset)
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
            reset = false;
        }
    }
}
