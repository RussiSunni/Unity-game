﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private void OnMouseDown()
    {
        SoundManagerScript.playHELLOWordSound();
    }
}
