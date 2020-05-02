using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAcademySpellBook : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("AcademySpellBook");
    }
}
