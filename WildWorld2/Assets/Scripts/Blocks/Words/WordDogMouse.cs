using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordDogMouse : MonoBehaviour
{

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {

        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

    }

    private void OnMouseDrag()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);

    }

    private void OnMouseUp()
    {
        transform.position = new Vector2(initialPosition.x, initialPosition.y);
    }
}
