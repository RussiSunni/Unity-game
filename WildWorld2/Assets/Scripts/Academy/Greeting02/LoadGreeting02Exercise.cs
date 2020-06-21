using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGreeting02Exercise : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("Greeting02Exercise");
    }
}
