using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecretaryText : MonoBehaviour
{
    static Text secretaryText;
    void Start()
    {
        secretaryText = GetComponent<Text>();
        secretaryText.text = "Please write your name, then click 'next'.";
    }

    public static void UpdateText()
    {
        secretaryText.text = "Hi " + Progress.nameString + ".";
    }

    void Update()
    {

    }
}
