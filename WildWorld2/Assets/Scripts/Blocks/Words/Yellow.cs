using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    Transform[] targetBlock = new Transform[4];
    private Vector2 initialPosition, mousePosition;
    private float deltaX, deltaY;
    public static bool locked, pressed, destroyed;



    void Start()
    {
        initialPosition = transform.position;
        targetBlock[0] = GameObject.Find("target_block-1").transform;
        targetBlock[1] = GameObject.Find("target_block-2").transform;
        targetBlock[2] = GameObject.Find("target_block-3").transform;
        targetBlock[3] = GameObject.Find("target_block-4").transform;
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
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                                              Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                                              Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f ||
                                               Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
        {
            this.gameObject.SetActive(false);
            destroyed = true;
            SoundManagerScript.playErrorSound();

        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);

        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.yellow = true;
    }
}
