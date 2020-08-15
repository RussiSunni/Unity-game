using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    Text results;
    int score, questionsCompleted;
    void Start()
    {
        score = PlayerPrefs.GetInt("cat") + PlayerPrefs.GetInt("dog") + PlayerPrefs.GetInt("horse") + PlayerPrefs.GetInt("bear") + PlayerPrefs.GetInt("wolf") + PlayerPrefs.GetInt("zebra")
               + PlayerPrefs.GetInt("owl") + PlayerPrefs.GetInt("monkey") + PlayerPrefs.GetInt("squirrel") + PlayerPrefs.GetInt("giraffe") + PlayerPrefs.GetInt("lion")
               + PlayerPrefs.GetInt("alligator") + PlayerPrefs.GetInt("rhinoceros") + PlayerPrefs.GetInt("duck") + PlayerPrefs.GetInt("pig") + PlayerPrefs.GetInt("donkey")
               + PlayerPrefs.GetInt("rabbit") + PlayerPrefs.GetInt("frog") + PlayerPrefs.GetInt("tiger") + PlayerPrefs.GetInt("goat") + PlayerPrefs.GetInt("chicken") + PlayerPrefs.GetInt("Elephant");

        results = GameObject.Find("Results").GetComponent<Text>();

        questionsCompleted = 0;

        for (int i = 0; i < QuestionBank.questions.Count; i++)
        {
            if (QuestionBank.questions[i].answered)
            {
                questionsCompleted++;
            }
        }

        results.text = score + " / " + questionsCompleted;
    }

    public void Resume()
    {
        SceneManager.LoadScene("Base");
    }
    public void Quit()
    {
        Application.Quit();
    }
}