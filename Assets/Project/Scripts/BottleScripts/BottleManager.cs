using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleManager : MonoBehaviour
{
    [SerializeField]
    private int maxOunces;
    private int currentOunces;

    [SerializeField]
    private DrinkManager.TypeOfDrink type;

    private void Awake()
    {
        currentOunces = maxOunces;
    }

    #region Getters
    public int GetCurrentOunces()
    {
        return currentOunces;
    }

    public DrinkManager.TypeOfDrink GetTypeOfDrink()
    {
        return type;
    }
    #endregion

    #region Setters
    public void RefillOunces()
    {
        currentOunces = maxOunces;
    }

    public void SubtractOneOunce()
    {
        currentOunces--;
    }
    #endregion


}
