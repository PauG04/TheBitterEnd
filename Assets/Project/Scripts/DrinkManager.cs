using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DrinkManager;

public class DrinkManager : MonoBehaviour
{
    #region ENUMS
    public enum TypeOfDrink
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

    public enum DrinkState
    {
        Idle,
        Shaked,
        Mixed
    }
    #endregion

    private List<TypeOfDrink> typeOfDrinks;
    private DrinkState drinkState;

    private void Awake()
    {
        typeOfDrinks = new List<TypeOfDrink>();
    }

    #region GETTERS
    public List<TypeOfDrink> GetTypeOfDrinks()
    {
        return typeOfDrinks;
    }

    public DrinkState GetDrinkState()
    {
        return drinkState;
    }
    #endregion
}
