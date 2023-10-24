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

    private void openMinimizeWindow()
    {
        appMinimize.transform.position = setTaskBarPosition.GetBarPosition();
        setTaskBarPosition.SetXPosition();
        appMinimize.SetActive(true);
        isOpen = true;
    }

}
