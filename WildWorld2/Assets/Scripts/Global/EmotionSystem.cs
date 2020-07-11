using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionSystem : MonoBehaviour
{
    private Sprite image1, image2, image3, image4;
    private Image imageComponent;

    void Start()
    {
        image1 = Resources.Load<Sprite>("Global/EmotionSystem/North African happy");
        image2 = Resources.Load<Sprite>("Global/EmotionSystem/North African neutral");
        image3 = Resources.Load<Sprite>("Global/EmotionSystem/North African angry");
        image4 = Resources.Load<Sprite>("Global/EmotionSystem/North African sad");

        imageComponent = this.GetComponent<Image>();
        imageComponent.sprite = image2;
    }
}
