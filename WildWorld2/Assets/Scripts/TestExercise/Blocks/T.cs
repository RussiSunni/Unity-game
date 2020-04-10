using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T : MonoBehaviour
{
    Transform[] targetBlock = new Transform[3];

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
    }

    private void OnMouseUp()
    {

        if (TestExerciseNext.catFlag == false)
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
            }
            else

            if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                pressed = false;
                locked = true;
                SoundManagerScript.playCorrectSound();
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }

        else if (TestExerciseNext.catFlag == true)
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                                 Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                                 Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
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
