using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : Block
{
    Transform targetBlock;
    void Start()
    {
        targetBlock = GameObject.Find("TargetBlock").transform;
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - targetBlock.position.x) <= 0.5f &&
                             Mathf.Abs(transform.position.y - targetBlock.position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock.position.x, targetBlock.position.y);
        }
    }
}

