using UnityEngine;

public class PetStats : Singleton<PetStats>
{
    float happiness = 100;
    float financialSecurity = 100;
    float health = 100;

    public float getHappiness => happiness;
    public float getFinancialSecurity => financialSecurity;
    public float getHealth => health;

    public void AffectHappiness(float amount)
    {
        happiness += amount;
        if (happiness > 100)
        {
            happiness = 100;
        }
        if (happiness <= 0)
        {
            GameOver();
        }
    }

    public void AffectFinancialSecurity(float amount)
    {
        financialSecurity += amount;
        if (financialSecurity > 100)
        {
            financialSecurity = 100;
        }
        if (financialSecurity <= 0)
        {
            GameOver();
        }
    }

    public void AffectHealth(float amount)
    {
        health += amount;
        if (health > 100)
        {
            health = 100;
        }
        if (health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Gameover");
    }
}
