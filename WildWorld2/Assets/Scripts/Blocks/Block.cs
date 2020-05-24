using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Vector2 initialPosition, mousePosition;
    public float deltaX, deltaY;
    public static bool locked, pressed, destroyed;


    // doubleclick
    public float firstClickTime, timeBetweenClicks;
    public bool coroutineAllowed;
    public int clickCounter;

    // rotation
    public Vector3 RotateStep = new Vector3(0, 180, 0);
    public float RotateSpeed = 5f;
    public Quaternion _targetRot = Quaternion.identity;


    protected virtual void Start()
    {
        initialPosition = transform.position;

        // doubleclick
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;
    }

    protected virtual void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    protected virtual void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
            pressed = true;
        }
    }

    protected virtual void OnMouseUp()
    {

    }

    // doubleclick
    // protected virtual IEnumerator DoubleClickDetection()
    // {

    // }

    protected virtual void Update()
    {
        // rotate
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRot, RotateSpeed * Time.deltaTime);
    }
}

