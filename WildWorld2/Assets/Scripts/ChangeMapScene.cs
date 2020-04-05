 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 using UnityEngine.UI;
 
 public class ChangeMapScene : MonoBehaviour {
    
    private SpriteRenderer rend;

    private Sprite map01, map02, map03;

    private int numberPresses = 0;
    
    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        map01 = Resources.Load<Sprite>("map01");
        map02 = Resources.Load<Sprite>("map02");
        map03 = Resources.Load<Sprite>("map03");
        rend.sprite = map01;
    }

 
      void OnMouseDown(){
            numberPresses++;

            if (numberPresses == 1) {
                rend.sprite = map02;
            }
            else if (numberPresses == 2) {
                rend.sprite = map03;
            }
      }


       private void Update()
        {
            if (Input.touchCount == 1) {
                rend.sprite = map02;
            }
            else if (Input.touchCount == 2) {
                rend.sprite = map03;
            }
        }

   
 }  