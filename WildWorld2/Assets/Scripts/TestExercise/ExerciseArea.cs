using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExerciseArea : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite bg1, bg2, bg3;

    public GameObject exerciseArea;

    public Camera camera1;
    public Camera camera2;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        bg1 = Resources.Load<Sprite>("cat_bg");
        bg2 = Resources.Load<Sprite>("dog_bg");
        bg3 = Resources.Load<Sprite>("owl_bg");
        rend.sprite = bg1;


        GameObject.Find("CAT").SetActive(false);
        GameObject.Find("DOG").SetActive(false);

        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = bg2;
            // if (!GameObject.Find("CAT(Clone)"))
            // {
            //     GameObject CAT = Instantiate(spawnee1) as GameObject;
            //     exerciseArea = GameObject.Find("ExerciseArea");
            //     CAT.transform.SetParent(exerciseArea.transform, false);
            //     CAT.SetActive(false);
            // }

        }

        if (TestExerciseNext.dogFlag)
        {
            rend.sprite = bg3;
            // if (!GameObject.Find("DOG(Clone)"))
            // {
            //     GameObject DOG = Instantiate(spawnee2) as GameObject;
            //     exerciseArea = GameObject.Find("ExerciseArea");
            //     DOG.transform.SetParent(exerciseArea.transform, false);
            //     DOG.SetActive(false);
            // }

        }
    }
}