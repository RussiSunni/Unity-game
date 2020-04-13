using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip errorSound, correctSound, newWordSound, CATWordSound, DOGWordSound, OWLWordSound, BEARWordSound, WOLFWordSound;

    static AudioSource audioSrc;



    // Start is called before the first frame update
    void Start()
    {
        errorSound = Resources.Load<AudioClip>("pop");
        correctSound = Resources.Load<AudioClip>("success");
        newWordSound = Resources.Load<AudioClip>("success_long");
        CATWordSound = Resources.Load<AudioClip>("sounds/CATSound");
        DOGWordSound = Resources.Load<AudioClip>("sounds/DOGSound");
        OWLWordSound = Resources.Load<AudioClip>("sounds/OWLSound");
        BEARWordSound = Resources.Load<AudioClip>("sounds/BEARSound");
        WOLFWordSound = Resources.Load<AudioClip>("sounds/WOLFSound");
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


    // words
    public static void playCATWordSound()
    {
        audioSrc.PlayOneShot(CATWordSound);
    }

    public static void playDOGWordSound()
    {
        audioSrc.PlayOneShot(DOGWordSound);
    }

    public static void playOWLWordSound()
    {
        audioSrc.PlayOneShot(OWLWordSound);
    }

    public static void playBEARWordSound()
    {
        audioSrc.PlayOneShot(BEARWordSound);
    }

    public static void playWOLFWordSound()
    {
        audioSrc.PlayOneShot(WOLFWordSound);
    }
}
