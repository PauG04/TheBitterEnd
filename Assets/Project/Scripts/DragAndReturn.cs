using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndReturn : MonoBehaviour
{
    private bool dragging = false;

    private Vector3 offset;

    [SerializeField]
    private Vector3 initialOffset;

    [SerializeField]
    private Transform currentWindowPosition;

private void Update()
    {
        if (dragging)
        {
            CalculatePosition();
        }
    }

    private void CalculatePosition()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        transform.position = initialOffset + currentWindowPosition.position;
        dragging = false;
    }
}
