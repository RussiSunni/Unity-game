 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class DisplayScore : MonoBehaviour {
 
     Text txt;
     private int currentscore=0;
 
     // Use this for initialization
     void Start () {
         txt = gameObject.GetComponent<Text>(); 
         txt.text="Score : " + currentscore;
     }
     
     // Update is called once per frame
     void Update () {
         txt.text="Score : " + currentscore;  
         currentscore = PlayerPrefs.GetInt("TOTALSCORE"); 
         PlayerPrefs.SetInt("SHOWSTARTSCORE",currentscore); 
     }
 }