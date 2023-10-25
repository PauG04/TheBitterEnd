using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragWindows : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    private Vector3 mousePos;
    private GameObject parentObject;

    [SerializeField] private ReOrderWindows reOrderWindows;

    private void Awake()
    {
        parentObject = transform.parent.gameObject;
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
            mousePos = new Vector3(mousePosToWorldPoint.x + offset.x, mousePosToWorldPoint.y + offset.y, parentObject.transform.position.z);
            parentObject.transform.position = mousePos;
            reOrderWindows.OrderGroupLayer(parentObject);
        }
    }

    private void OnMouseDown()
    {
        offset = new Vector3(
            parentObject.transform.position.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 
            parentObject.transform.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y
            );
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

}
