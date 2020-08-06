using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheNaturalWorld : MonoBehaviour
{

    public static IDictionary<int, string> theNaturalWorld = new Dictionary<int, string>()
    {
        {1, "Cat"},
        {2, "Dog"},
        {3, "Horse"},
        {4, "Bear"},
        {5, "Wolf"},
        {6, "Zebra"},
        {7, "Owl"},
        {8, "Monkey"},
        {9, "Squirrel"},
        {10, "Giraffe"},
        {11, "Lion"},
        {12, "Alligator"},
        {13, "Rhinoceros"},
        {14, "Duck"},
        {15, "Pig"},
        {16, "Donkey"},
        {17, "Rabbit"},
        {18, "Frog"},
        {19, "Tiger"},
        {20, "Goat"},
        {21, "Chicken"},
        {22, "Elephant"}
    };



    void Start()
    {
        PlayerPrefs.SetInt("Cat", 0);
        PlayerPrefs.SetInt("Dog", 0);
        PlayerPrefs.SetInt("Horse", 0);
        PlayerPrefs.SetInt("Bear", 0);
        PlayerPrefs.SetInt("Wolf", 0);
        PlayerPrefs.SetInt("Zebra", 0);
        PlayerPrefs.SetInt("Owl", 0);
        PlayerPrefs.SetInt("Monkey", 0);
        PlayerPrefs.SetInt("Squirrel", 0);
        PlayerPrefs.SetInt("Giraffe", 0);
        PlayerPrefs.SetInt("Lion", 0);
        PlayerPrefs.SetInt("Alligator", 0);
        PlayerPrefs.SetInt("Rhinoceros", 0);
        PlayerPrefs.SetInt("Duck", 0);
        PlayerPrefs.SetInt("Pig", 0);

        PlayerPrefs.SetInt("Donkey", 0);
        PlayerPrefs.SetInt("Rabbit", 0);
        PlayerPrefs.SetInt("Frog", 0);
        PlayerPrefs.SetInt("Tiger", 0);
        PlayerPrefs.SetInt("Goat", 0);
        PlayerPrefs.SetInt("Chicken", 0);
        PlayerPrefs.SetInt("Elephant", 0);


    }

}
