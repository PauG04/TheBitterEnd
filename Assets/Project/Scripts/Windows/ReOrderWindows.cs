using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ReOrderWindows : Button
{
    private GetListOfWindows listOfWindows;
    private SortingGroup sortingGroup;
    private int numberOfWindows;
    private List<GameObject> windows;

    private void Awake()
    {
        #region Get Components
        listOfWindows = transform.parent.GetComponent<GetListOfWindows>();
        sortingGroup = GetComponent<SortingGroup>();
        #endregion

        numberOfWindows = listOfWindows.GetNumberOfWindows();
        windows = listOfWindows.GetWindowsList();
    }

    private void Update()
    {
        if (SimulateButton(gameObject.name))
        {
            OrderGroupLayer();
        }
    }

    private void OrderGroupLayer()
    {
        //sortingGroup.sortingOrder = numberOfWindows;
    }
}
