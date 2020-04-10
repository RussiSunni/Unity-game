using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExerciseArea : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite bg1, bg2, bg3, bg4;

    public GameObject exerciseArea;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        bg1 = Resources.Load<Sprite>("cat_bg");
        bg2 = Resources.Load<Sprite>("dog_bg");
        bg3 = Resources.Load<Sprite>("owl_bg");
        bg4 = Resources.Load<Sprite>("bear_bg");
        rend.sprite = bg1;

        GameObject.Find("CAT").SetActive(false);
        GameObject.Find("DOG").SetActive(false);
        GameObject.Find("Fairy animation").SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = bg2;
        }

        if (TestExerciseNext.dogFlag)
        {
            rend.sprite = bg3;
        }

        if (TestExerciseNext.owlFlag)
        {
            rend.sprite = bg4;
        }
    }
}