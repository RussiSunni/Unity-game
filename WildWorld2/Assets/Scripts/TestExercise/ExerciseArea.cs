using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExerciseArea : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite bg1, bg2;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        bg1 = Resources.Load<Sprite>("cat_bg");
        bg2 = Resources.Load<Sprite>("dog_bg");
        rend.sprite = bg1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.numberPresses == 1)
        {
            rend.sprite = bg2;
        }
    }
}
