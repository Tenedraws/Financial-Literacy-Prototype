using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : Singleton<PetStats>
{
    float happiness;
    float financialSecurity;
    float health;

    public float getHappiness => happiness;
    public float getFinancialSecurity => financialSecurity;
    public float getHealth => health;

    private void Start()
    {
        //100 is max for all stats
        happiness = 100;
        financialSecurity = 100;
        health = 100; 
    }

    public void AffectHappiness(float amount)
    {
        happiness += amount; 
        if(happiness <= 0)
        {
            GameOver();
        }
    }

    public void AffectFinancialSecurity(float amount)
    {
        financialSecurity += amount;
        if(financialSecurity <= 0)
        {
            GameOver();
        }
    }

    public void AffectHealth(float amount)
    {
        health += amount; 
        if(health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Gameover");
    }
}
