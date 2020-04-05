using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterAMouse : MonoBehaviour
{
    [SerializeField]
    private Transform letterAPlace;

    public Transform letterCPlace;

    public Transform letterTPlace;

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;

    public static bool pressed;

    private string sceneName;

    AudioSource audioData;



    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

        if (locked)
        {

        }

        audioData = GetComponent<AudioSource>();

        letterCPlace = GameObject.Find("cat_target_block-c").transform;
        letterTPlace = GameObject.Find("cat_target_block-t").transform;
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

        // if put in incorrect posistion - CAT
        if (Mathf.Abs(transform.position.x - letterCPlace.position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - letterCPlace.position.y) <= 0.5f ||
                 Mathf.Abs(transform.position.x - letterTPlace.position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - letterTPlace.position.y) <= 0.5f)
        {
            Destroy(this.gameObject);
        }

        if (sceneName == "CatExercise" || sceneName == "BearExercise")
        {

            if (Mathf.Abs(transform.position.x - letterAPlace.position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - letterAPlace.position.y) <= 0.5f)
            {
                transform.position = new Vector2(letterAPlace.position.x, letterAPlace.position.y);
                pressed = false;
                locked = true;
                audioData.Play();
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
