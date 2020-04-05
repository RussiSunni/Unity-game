using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class LoadArtemis : MonoBehaviour
{
        public void ChangeScene()
        {
            SceneManager.LoadScene ("ArtemisIntro");
        }
}
