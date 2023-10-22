using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowControl : MonoBehaviour
{

    public void CloseWindow()
    {
        Destroy(transform.parent.gameObject);
    }
    public void MaximeWindow()
    {

    }
    public void HideWindow()
    {

    }
}
