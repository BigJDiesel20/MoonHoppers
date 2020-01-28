using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{
    public float amount;
    public float amountMin;
    public float amountMax;
    public bool limitReached;
    public bool isMinLimitReached;
    public bool isMaxLimitReached;
    public bool isDead;

    public  Stats()
    {

    }

    public Stats(float amount, float amountMin, float amountMax)
    {
        this.amount = amount;
        this.amountMin = amountMin;
        this.amountMax = amountMax;
    }
    public Stats(float amount, float amountMin, float amountMax, bool limitReached)
    {
        this.amount = amount;
        this.amountMin = amountMin;
        this.amountMax = amountMax;
        this.limitReached = limitReached;
    }
    public Stats(float amount, float amountMin, float amountMax,bool isMinLimitReached, bool isMaxLimitReached)
    {
        this.amount = amount;
        this.amountMin = amountMin;
        this.amountMax = amountMax;
        this.isMinLimitReached = isMinLimitReached;
        this.isMaxLimitReached = isMaxLimitReached;
    }


    public void Increase(float ratePerSecond)
    {
        amount = amount >= amountMax? amountMax : amount += ratePerSecond * Time.deltaTime;
        
    }
    public void Decrease(float ratePerSecond)
    {
        amount = amount <= amountMin ? amountMin : amount -= ratePerSecond * Time.deltaTime;
    }

    public void IncreaseToLimit(float ratePerSecond)
    {
        amount = amount >= amountMax ? amountMax : amount += ratePerSecond * Time.deltaTime;

        limitReached = amount >= amountMax ? false : limitReached;

    }
    public void DecreaseToLimit(float ratePerSecond)
    {
        amount = amount <= amountMin ? amountMin : amount -= ratePerSecond * Time.deltaTime;
        limitReached = amount <= amountMin ? true : limitReached;
        
    }

    public void SetLimitReached(bool limitReached)
    {
        this.limitReached = limitReached;
    }

    public void OnDeath(bool isDead)
    {
        isDead = true;
    }
    
}


