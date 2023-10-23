using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakerTaken : MonoBehaviour
{
    [SerializeField]
    private ShakerManager shakerManager;
    [SerializeField]
    private DrinkScript drinkScript;
    [SerializeField]
    private GameObject cup;
    [SerializeField]
    private Shake shake;
    private ShakerManager.ShakerState shakerState;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Shaker" && drinkScript.GetIsMouseNotPressed())
        {
            shakerManager.GetShakerState();
            cup.SetActive(true);
            shakerState = shakerManager.GetShakerState();
            Debug.Log(shakerState);
            shake.SetProgres(0);
        }
    }
   
}
