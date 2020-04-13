using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool CATAttained, DOGAttained;

    public GameObject CAT, DOG;

    void Start()
    {
        CAT = GameObject.Find("CAT");
        DOG = GameObject.Find("DOG");


        CAT.SetActive(false);
        DOG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CATAttained)
        {
            CAT.SetActive(true);
        }

        if (DOGAttained)
        {
            DOG.SetActive(true);
        }
    }
}
