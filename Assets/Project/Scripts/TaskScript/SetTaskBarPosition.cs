using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UIElements;

public class SetTaskBarPosition : MonoBehaviour
{
    [SerializeField]
    private float xPosition;
    private float xPosition2;
    [SerializeField]
    private float orignalX;
    private int sume = 0;
    private bool[] isRight;
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
        isRight = new bool[orderTaskBar.Length];
        for(int i = 0; i<isOpen.Length; i++) 
        {
            isOpen[i] = false;
            isRight[i] = false;
        }
        orignalX = xPosition;
        xPosition2 = xPosition;
    }
    private void Update()
    {       
        OpenIcon();
        CloseIcon();          
    }

    private void OpenIcon()
    {
        for (int i = 0; i < setMinimize.icon.Length; i++)
        {
            if (orderTaskBar[i].IsOpen() && !isOpen[i])
            {  
                    setMinimize.icon[i].transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
                
                setMinimize.icon[i].SetActive(true);
                SetXPosition(2);
                isOpen[i] = true;
            }
        }
        sume = 0;

    }

    private void CloseIcon()
    {
        for (int i = 0; i < setMinimize.icon.Length; i++)
        {
            if (!orderTaskBar[i].IsOpen() && isOpen[i])
            {
                setMinimize.icon[i].SetActive(false);
                setOriginalX(setMinimize.icon[i].transform.position.x);
                SetIsOpenFalse();
                SetIsRightTrue(i);
            }
        }

    }

    private void SetXPosition(float x)
    {
        xPosition += x;
    }

    private void setOriginalX(float position)
    {
        xPosition = position;
    }

    private void SetIsOpenFalse()
    {
        for (int j = 0; j < isOpen.Length; j++)
        {
            isOpen[j] = false;
        }
    }

    private void SetIsRightTrue(int i)
    {
        for(int j = 0; j < isOpen.Length; j++)
        {
            if(setMinimize.icon[j].transform.position.x > xPosition)
            {
                isOpen[j] = false;
                Debug.Log("si");
            }
                
        }
    }
 
}

