using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenApp : MonoBehaviour
{
    [SerializeField]
    private GameObject app;
    private bool isOpen = false;

    private void OnMouseDown()
    {
        if(!isOpen)
        {
            app.SetActive(true);
            isOpen = true;

        }   
    }

    public bool GetIsOpen()
    {
        return isOpen;
    }
}
