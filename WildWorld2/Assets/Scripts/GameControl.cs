using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    
    [SerializeField]
    private GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (LetterCTouch.locked && LetterATouch.locked && LetterTTouch.locked || LetterAMouse.locked && LetterCMouse.locked && LetterTMouse.locked)
            winText.SetActive(true);
            
    }
}
