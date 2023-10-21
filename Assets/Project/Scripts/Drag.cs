using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField] private GameObject dragObject;

    private bool dragging = false;
    
    private Vector3 offset;

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
        offset = dragObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
