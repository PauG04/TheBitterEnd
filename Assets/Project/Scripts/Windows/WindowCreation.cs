using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class WindowCreation : MonoBehaviour
{
    [SerializeField] private WindowDataObject windowData;

    private string appName;
    private string appDescription;

    private void Awake()
    {
        appName = windowData.values.name;
        appDescription = windowData.values.description;

        gameObject.transform.localScale = new Vector3(windowData.values.width, windowData.values.height, 1);
    }
}
