using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTaskBarPosition : MonoBehaviour
{
    [SerializeField]
    private float xPosition;
    private bool notMovet = false;
    public Vector3 GetBarPosition()
    {
        return new Vector3(xPosition, transform.position.y, transform.position.z);
    }

    public void SetXPosition()
    {
        xPosition += 2;

    }

}

