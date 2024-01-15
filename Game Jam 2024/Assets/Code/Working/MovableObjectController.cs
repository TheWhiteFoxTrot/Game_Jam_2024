using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObjectController : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 offset;

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = cursorPosition + offset;
        }
    }
}
