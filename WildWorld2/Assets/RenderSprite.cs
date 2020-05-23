using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderSprite : MonoBehaviour
{

    SpriteRenderer rend;
    Sprite character1, character2, character3, character4;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        character1 = Resources.Load<Sprite>("global/character1");
        rend.sprite = character1;



    }
}
