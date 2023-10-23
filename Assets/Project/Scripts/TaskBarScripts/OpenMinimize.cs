using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMinimize : MonoBehaviour
{
    [SerializeField]
    private Minimize minimize;

    private void OnMouseDown()
    {
        minimize.SetIsMinimize();
    }
}
