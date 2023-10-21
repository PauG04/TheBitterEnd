using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourOunces : MonoBehaviour
{
    private BottleManager bottle;
    private ShakerManager shaker;

    [SerializeField]
    private BoxCollider2D boxCollider;

    [SerializeField]
    private BoxCollider2D shakerCollider;

    private void OnMouseUp()
    {
        if (boxCollider.IsTouching(shakerCollider) && bottle.GetCurrentOunces() > 0)
        {
            shaker.AddOunce(bottle.GetTypeOfDrink());
            bottle.SubtractOneOunce();
            //sumar +1 al contador
        }
    }
}
