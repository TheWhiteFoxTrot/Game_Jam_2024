using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObjectController : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 offset;

    void OnMouseDown()
    {
        Debug.Log("drag");
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        Debug.Log("stopdrag");
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("cursor: "+ cursorPosition);
            transform.position = cursorPosition + offset;
            Debug.Log("offset: "+ cursorPosition+offset);
        }
    }
}
