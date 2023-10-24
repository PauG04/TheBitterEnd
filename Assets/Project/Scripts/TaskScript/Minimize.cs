using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimize : MonoBehaviour
{
    [SerializeField]
    private bool isMinimize = false;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (isMinimize)
        {
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
        }
        else if (!isMinimize)
        {
            spriteRenderer.enabled = true;
            boxCollider2D.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        isMinimize = true;
    }

    public void SetIsMinimize()
    {
        isMinimize = false;
    }

}

