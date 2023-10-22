using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : Button
{
    [SerializeField] private GameObject objectToDestroy;

    private void Update()
    {
        if(SimulateButton(gameObject.name))
        {
            CloseApp();
        }
    }

    private void CloseApp()
    {
        Debug.Log(gameObject.name);
        //Destroy(objectToDestroy.gameObject);
    }
}
