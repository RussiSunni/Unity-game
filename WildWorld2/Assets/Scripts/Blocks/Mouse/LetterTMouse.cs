using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterTMouse : MonoBehaviour
{
    private Transform letterTPlace;

    private Transform letterAPlace;

    private Transform letterCPlace;

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;

    public static bool pressed;

    private string sceneName;



    void Start()
    {
        initialPosition = transform.position;
        if (locked)
        {
            //Destroy(this.gameObject);
        }

        locked = false;

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "CatExercise")
        {
            letterAPlace = GameObject.Find("cat_target_block-a").transform;
            letterCPlace = GameObject.Find("cat_target_block-c").transform;
            letterTPlace = GameObject.Find("cat_target_block-t").transform;
        }
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
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "CatExercise")
        {
            // if put in incorrect posistion - CAT
            if (Mathf.Abs(transform.position.x - letterAPlace.position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - letterAPlace.position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - letterCPlace.position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - letterCPlace.position.y) <= 0.5f)
            {
                Destroy(this.gameObject);
                SoundManagerScript.playErrorSound();
            }


            if (Mathf.Abs(transform.position.x - letterTPlace.position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - letterTPlace.position.y) <= 0.5f)
            {
                transform.position = new Vector2(letterTPlace.position.x, letterTPlace.position.y);
                pressed = false;
                locked = true;
                SoundManagerScript.playCorrectSound();
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }

        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

}
