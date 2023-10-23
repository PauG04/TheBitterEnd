using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerManager : MonoBehaviour
{
    [SerializeField]
    private int maxOunces;
    private int currentOunces = 0;
    private bool isFull = false;

    private List<DrinkManager.TypeOfDrink> ouncesInShaker;

    private DrinkManager.DrinkState shakerState;

    private void Awake()
    {
        ouncesInShaker = new List<DrinkManager.TypeOfDrink>();
    }

    public void AddOunce(DrinkManager.TypeOfDrink ounceToAdd)
    {
        if (!isFull)
        {
            ouncesInShaker.Add(ounceToAdd);
            currentOunces++;
            if (currentOunces >= maxOunces)
            {
                isFull = true;
            }
        }
    }

    public List<DrinkManager.TypeOfDrink> GetOuncesInShaker()
    {
        return ouncesInShaker;
    }

    public DrinkManager.DrinkState GetShakerState()
    {
        return shakerState;
    }

    public void SetShakerState(DrinkManager.DrinkState state)
    {
        shakerState = state;
    }
}
