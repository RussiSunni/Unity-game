using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    
    public static AudioClip jumpSound;
    static AudioSource audioSrc;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("pop");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void playSound()
    {
        audioSrc.PlayOneShot(jumpSound);
    }
}
