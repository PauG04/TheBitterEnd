using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDrink : MonoBehaviour
{
    private bool CheckCorrectOunces(List<BottleManager.typeOfDrink> wantedDrink, List<BottleManager.typeOfDrink> makedDrink)
    {
        wantedDrink.Sort(SortFunc);
        makedDrink.Sort(SortFunc);
        if (CompareOuncesLists(wantedDrink, makedDrink))
            return true;
        return false;
    }

    private int SortFunc(BottleManager.typeOfDrink a, BottleManager.typeOfDrink b)
    {
        if (a < b)
        {
            return -1;
        }
        else if (a > b)
        {
            return 1;
        }
        return 0;
    }

    //Esta funcion se tiene q mejorar
    private bool CompareOuncesLists(List<BottleManager.typeOfDrink> wantedDrink, List<BottleManager.typeOfDrink> makedDrink)
    {
        if (wantedDrink.Count != makedDrink.Count)
            return false;

        for (int i = 0; i < wantedDrink.Count; i++)
        {
            if (wantedDrink[i] != makedDrink[i])
                return false;
        }

        return true;
    }
}
