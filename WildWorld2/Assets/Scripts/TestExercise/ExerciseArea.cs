using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExerciseArea : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite bg1, bg2, bg3;

    public GameObject exerciseArea;

    public GameObject spawnee1;

    public GameObject spawnee2;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        bg1 = Resources.Load<Sprite>("cat_bg");
        bg2 = Resources.Load<Sprite>("dog_bg");
        bg3 = Resources.Load<Sprite>("owl_bg");
        rend.sprite = bg1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = bg2;
            if (!GameObject.Find("CAT(Clone)"))
            {
                GameObject childObject1 = Instantiate(spawnee1) as GameObject;
                exerciseArea = GameObject.Find("ExerciseArea");
                childObject1.transform.SetParent(exerciseArea.transform, false);
            }

        }

        if (TestExerciseNext.dogFlag)
        {
            rend.sprite = bg3;
            if (!GameObject.Find("DOG(Clone)"))
            {
                GameObject childObject2 = Instantiate(spawnee2) as GameObject;
                exerciseArea = GameObject.Find("ExerciseArea");
                childObject2.transform.SetParent(exerciseArea.transform, false);

            }

        }
    }
}