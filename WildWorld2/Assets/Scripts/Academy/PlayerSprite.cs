using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerSprite : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite playerSprite;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        if (Progress.playerCharacter == "English")
            playerSprite = Resources.Load<Sprite>("global/english_sprite");
        else if (Progress.playerCharacter == "Japanese")
            playerSprite = Resources.Load<Sprite>("global/japanese_sprite");
        else if (Progress.playerCharacter == "North African")
            playerSprite = Resources.Load<Sprite>("global/north_african_sprite");
        else if (Progress.playerCharacter == "South African")
            playerSprite = Resources.Load<Sprite>("global/south_african_sprite");

        rend.sprite = playerSprite;

    }

}
