using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Base");
        AnimalNamesQuestionBank.LoadQuestionList();
    }
    public void Load()
    {
        GameControl.control.Load();
        SceneManager.LoadScene("Base");

        AnimalNamesQuestionBank.LoadQuestionList();
    }
}