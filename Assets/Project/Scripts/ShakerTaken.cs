using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerTaken : MonoBehaviour
{
    [SerializeField]
    private ShakerManager shakerManager;
    [SerializeField]
    private DrinkScript drinkScript;
    [SerializeField]
    private GameObject cup;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Shaker" && drinkScript.GetIsMouseNotPressed())
        {
            shakerManager.GetShakerState();
            cup.SetActive(true);
            Debug.Log(shakerManager.GetShakerState());
        }
    }
   
}
