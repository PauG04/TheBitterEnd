using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleManager : MonoBehaviour
{
    private int maxOunces;
    private int currentOunces;

    public enum typeOfDrink 
    { 
        //Alcoholic Drinks
        Rum,
        Gin,
        Vodka,
        Whiskey,
        Tequila,
        //Juices
        OrangeJuice,
        LemonJuice,
        //Soft Drinks
        Cola,
        Soda,
        Tonic
    }

    [SerializeField]
    private typeOfDrink type;

    public void RefillOunces()
    {
        currentOunces = maxOunces;
    }

    public void SubtractOneOunce()
    {
        currentOunces--;
    }

    public int GetCurrentOunces()
    { 
        return currentOunces; 
    }

    public typeOfDrink GetTypeOfDrink()
    {
        return type;
    }
}
