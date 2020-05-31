using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadAcademy : MonoBehaviour
{
    private string sceneName;

    public void ChangeScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        Progress.previousScene = scene.name;
        SceneManager.LoadScene("Academy");
    }
}
