using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : MonoBehaviour
{
    private bool isWorking = true; //esta variable se activa y se desactiva cuando se abre la app de trabajo
    private bool canTakeOrder = false;
    private bool isDrinkPrepares = true; //esta variabl se activa al entregar la bebida 
    private float currentTime = 0.0f;
    [SerializeField]
    private float maxTime;
    [SerializeField]
    private int minTimeBetweenOrder;
    [SerializeField]
    private int maxTimeBetweenOrder;

    private void Start()
    {
        maxTime = Random.Range(minTimeBetweenOrder, maxTimeBetweenOrder);
    }
    void Update()
    {
        if (isWorking && canTakeOrder)
        {
            TakeOrder();
        }
        else if (isWorking && isDrinkPrepares)
        {
            Timer();
        }
    }

    private void TakeOrder()
    {
        isDrinkPrepares = false;
        canTakeOrder = false;
        Debug.Log("I want a Beer");
    }

    private void Timer()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            canTakeOrder = true;
            currentTime = 0.0f;
            maxTime = Random.Range(minTimeBetweenOrder, maxTimeBetweenOrder);
        }

    }
}
