using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragWindows : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    private Vector2 mousePos;
    private Transform parentObject;

    private void Start()
    {
        parentObject = transform.parent;
    }

    private void Update()
    {
        Drag();
    }

    private void Drag()
    {
        if (isDragging)
        {
            Vector3 mousePosToWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector2(mousePosToWorldPoint.x + offset.x, mousePosToWorldPoint.y + offset.y);
            parentObject.position = mousePos;
        }
    }

    private void OnMouseDown()
    {
        offset = new Vector3(parentObject.position.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x, parentObject.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

}
