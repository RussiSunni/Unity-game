using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Z : MonoBehaviour
{
    Transform[] targetBlock = new Transform[5];
    private Vector2 initialPosition, mousePosition;
    private float deltaX, deltaY;
    public static bool locked, pressed, destroyed, placed;
    private GameObject fairy;
    Animator fairyAnimator;

    private string sceneName;

    // doubleclick
    private float firstClickTime, timeBetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;

    // rotation
    public Vector3 RotateStep = new Vector3(0, 180, 0);
    public float RotateSpeed = 5f;
    private Quaternion _targetRot = Quaternion.identity;

    // instantiate copy
    GameObject letterZ;
    Transform parent;

    void Start()
    {
        initialPosition = transform.position;

        targetBlock[0] = GameObject.Find("target_block-1").transform;
        targetBlock[1] = GameObject.Find("target_block-2").transform;
        targetBlock[2] = GameObject.Find("target_block-3").transform;
        targetBlock[3] = GameObject.Find("target_block-4").transform;
        targetBlock[4] = GameObject.Find("target_block-5").transform;

        parent = GameObject.Find("ExerciseArea").transform;
        letterZ = (GameObject)Resources.Load("prefabs/z", typeof(GameObject));

        Scene scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
        Debug.Log(sceneName);
        if (sceneName == "ArtemisExercise")
        {
            fairy = GameObject.Find("Fairy");
            fairyAnimator = fairy.GetComponent<Animator>();
        }

        // doubleclick
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;
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
        if (sceneName == "ArtemisExercise")
        {
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
        }
    }

    private void OnMouseUp()
    {
        Scene scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
        if (sceneName == "SecretaryExercise")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[0] = "z";
                placed = true;
                Transform newZ = Instantiate(letterZ.transform) as Transform;
                newZ.transform.parent = parent.transform;
                newZ.transform.localPosition = new Vector2(-4.368f, 1.88f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[1] = "z";
                placed = true;
                Transform newZ = Instantiate(letterZ.transform) as Transform;
                newZ.transform.parent = parent.transform;
                newZ.transform.localPosition = new Vector2(-4.368f, 1.88f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[2] = "z";
                placed = true;
                Transform newZ = Instantiate(letterZ.transform) as Transform;
                newZ.transform.parent = parent.transform;
                newZ.transform.localPosition = new Vector2(-4.368f, 1.88f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[3] = "z";
                placed = true;
                Transform newZ = Instantiate(letterZ.transform) as Transform;
                newZ.transform.parent = parent.transform;
                newZ.transform.localPosition = new Vector2(-4.368f, 1.88f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[4].position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - targetBlock[4].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[4].position.x, targetBlock[4].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[4] = "z";
                placed = true;
                Transform newZ = Instantiate(letterZ.transform) as Transform;
                newZ.transform.parent = parent.transform;
                newZ.transform.localPosition = new Vector2(-4.368f, 1.88f);
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
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
                if (sceneName == "ArtemisExercise")
                {
                    fairyAnimator.runtimeAnimatorController = Resources.Load("fairy disappointed 1") as RuntimeAnimatorController;
                }
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }

        // doubleclick
        if (Input.GetMouseButtonUp(0))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    // doubleclick
    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;

        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                SoundManagerScript.playZLetterSound();
                _targetRot *= Quaternion.Euler(RotateStep);
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
    void Update()
    {
        // rotate
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRot, RotateSpeed * Time.deltaTime);
    }

}

