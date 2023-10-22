using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragWindows : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    private Vector2 mousePos;

    private void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosToWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector2(mousePosToWorldPoint.x + offset.x, mousePosToWorldPoint.y + offset.y);
            transform.position = mousePos;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }
}
