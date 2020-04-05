using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeIntroScene : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite secretary, teacher;

    private int numberPresses = 0;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        secretary = Resources.Load<Sprite>("secretary");
        teacher = Resources.Load<Sprite>("teacher");
        rend.sprite = secretary;
    }


    // void OnMouseDown()
    // {
    //     numberPresses++;

    //     if (numberPresses == 1)
    //     {
    //         rend.sprite = teacher;
    //     }
    // }


    private void Update()
    {
        // if (Input.touchCount == 1)
        // {
        //     rend.sprite = teacher;
        // }

        if (IntroNextScene.numberPresses == 1)
        {
            rend.sprite = teacher;
        }
    }
}