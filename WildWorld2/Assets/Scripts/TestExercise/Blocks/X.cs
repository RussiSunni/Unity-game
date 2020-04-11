using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{
    Transform[] targetBlock = new Transform[3];

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;

    public static bool pressed;

    public static bool destroyed;


    void Start()
    {
        initialPosition = transform.position;

        targetBlock[0] = GameObject.Find("target_block-1").transform;
        targetBlock[1] = GameObject.Find("target_block-2").transform;
        targetBlock[2] = GameObject.Find("target_block-3").transform;

    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
            pressed = true;
        }
        SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
    }

    private void OnMouseUp()
    {


        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                 Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                 Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
        {
            this.gameObject.SetActive(false);
            destroyed = true;
            SoundManagerScript.playErrorSound();
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy04;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
        }
    }
}
