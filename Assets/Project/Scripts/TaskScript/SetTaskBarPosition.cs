using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UIElements;

public class SetTaskBarPosition : MonoBehaviour
{
    [SerializeField]
    private float xPosition;
    [SerializeField]
    private float xPosition2;
    [SerializeField]
    private NewBehaviourScript[] orderTaskBar;
    private bool[] isOpen;
    private SetMinimize setMinimize;

    private void Awake()
    {
        setMinimize= GetComponent<SetMinimize>();
    }

    private void Start()
    {
        isOpen = new bool[orderTaskBar.Length];
        for(int i = 0; i<isOpen.Length; i++) 
        {
            isOpen[i] = false;
        }
    }
    private void Update()
    {
        for (int i = 0; i< setMinimize.icon.Length; i++) 
        {
            OpenIcon(i);
            CloseIcon(i);
        }       
    }

    private void OpenIcon(int i)
    {
        if (orderTaskBar[i].IsOpen() && !isOpen[i])
        {
            setMinimize.icon[i].transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
            setMinimize.icon[i].SetActive(true);
            SetXPosition(2);
            isOpen[i] = true;
        }
    }

    private void CloseIcon(int i)
    {
        if (!orderTaskBar[i].IsOpen() && isOpen[i])
        {
            setMinimize.icon[i].SetActive(false);
            SetXPosition2();
            for (int j = 0; j < isOpen.Length; j++)
            {
                isOpen[j] = false;
            }
        }
    }

    private void SetXPosition(float x)
    {
        xPosition += x;
    }

    private void SetXPosition2()
    {
        xPosition = xPosition2;
    }
 
}

