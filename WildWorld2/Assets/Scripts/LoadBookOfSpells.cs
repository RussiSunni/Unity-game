using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class LoadBookOfSpells : MonoBehaviour
{
        public void ChangeScene()
        {
            SceneManager.LoadScene ("BookOfSpells");
        }
}
