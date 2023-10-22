using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerManager : MonoBehaviour
{
    [SerializeField]
    private int maxOunces;
    private int currentOunces = 0;
    private bool isFull = false;

    private List<BottleManager.typeOfDrink> ouncesInShaker;

    public enum ShakerState
    {
        Idle,
        Shaked,
        Mixed
    }

    private void Awake()
    {
        ouncesInShaker = new List<BottleManager.typeOfDrink>();
    }

    public void AddOunce(BottleManager.typeOfDrink ounceToAdd)
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

    public List<BottleManager.typeOfDrink> GetOuncesInShaker()
    {
        return ouncesInShaker;
    }


}
