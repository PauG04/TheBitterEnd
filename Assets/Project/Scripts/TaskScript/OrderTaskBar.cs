using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private OpenApp openApp;
    [SerializeField]
    private GameObject appMinimize;
    [SerializeField]
    private SetTaskBarPosition setTaskBarPosition;
    private bool isOpen = false;
    [SerializeField]
    private int differenceX;

    private void Awake()
    {
        openApp = GetComponent<OpenApp>();
    }
    private void OnMouseDown()
    {
        if (openApp.GetIsOpen() && !isOpen)
        {
            openMinimizeWindow();
        }      
    }

    private void Update()
    {                 
        if (!openApp.GetIsOpen() && isOpen)
        {
            closeMinimizeWindos();
        }
    }

    private void openMinimizeWindow()
    {
        isOpen = true;
    }

    private void closeMinimizeWindos()
    {
        isOpen = false;
    }

    public bool IsOpen()
    {
        return isOpen;
    }

}
