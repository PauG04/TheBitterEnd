using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourOunces : MonoBehaviour
{
    private BottleManager bottle;

    [SerializeField]
    private OuncesCounter ouncesCounter;

    [SerializeField]
    private ShakerManager shaker;

    private BoxCollider2D boxCollider;

    [SerializeField]
    private BoxCollider2D shakerCollider;

    private void Awake()
    {
        bottle = GetComponent<BottleManager>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnMouseUp()
    {
        if (boxCollider.IsTouching(shakerCollider) && bottle.GetCurrentOunces() > 0)
        {
            shaker.AddOunce(bottle.GetTypeOfDrink());
            bottle.SubtractOneOunce();
            ouncesCounter.AddOneToCounter();
        }
    }
}
