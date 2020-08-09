using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleQuestion : MonoBehaviour
{
    public int number;
    public string questionName;
    public Sprite sprite;
    public List<string> answerOptions = new List<string>();
    public List<string> tags = new List<string>();
    public bool knownByLearner;
}