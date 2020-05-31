using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Transform player;
    // public static string prevScene = "";
    // public static string currentScene = "";

    // public virtual void Start()
    // {
    //     // Meant to be extended/overwritten by a scene script
    //     currentScene = SceneManager.GetActiveScene().name;
    // }

    // public void LoadScene(string sceneName)
    // {
    //     prevScene = currentScene;
    //     SceneManager.LoadScene(sceneName);
    // }

    void Start()
    {
        if (Progress.previousScene == "Hub")
        {
            player.position = new Vector2(0, 0);
        }
    }
}
