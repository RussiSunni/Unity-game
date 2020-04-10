using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip errorSound;

    public static AudioClip correctSound, newWordSound;

    static AudioSource audioSrc;



    // Start is called before the first frame update
    void Start()
    {
        errorSound = Resources.Load<AudioClip>("pop");
        correctSound = Resources.Load<AudioClip>("success");
        newWordSound = Resources.Load<AudioClip>("success_long");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public static void playCorrectSound()
    {
        audioSrc.PlayOneShot(correctSound);
    }
    public static void playErrorSound()
    {
        audioSrc.PlayOneShot(errorSound);
    }

    public static void playNewWordSound()
    {
        audioSrc.PlayOneShot(newWordSound);
    }
}
