using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerManager : MonoBehaviour
{
    public enum ShakerState
    {
        Idle,
        Shaked,
        Mixed
    }

    private List<BottleManager.typeOfDrink> ouncesInShaker;

    public void AddOunce(BottleManager.typeOfDrink ounceToAdd)
    {
        ouncesInShaker.Add(ounceToAdd);
    }

    public List<BottleManager.typeOfDrink> GetOuncesInShaker()
    {
        return ouncesInShaker;
    }


}
