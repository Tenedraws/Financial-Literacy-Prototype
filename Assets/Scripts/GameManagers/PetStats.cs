using UnityEngine;

public class PetStats : Singleton<PetStats>
{
    float happiness = 100;
    float financialSecurity;
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
            Endscreen.Instance.endText.text = "GAME OVER \n Your happiness hit 0. Seems like you were neglecting your emotional health." +
                                              "Being financially responsible doesn't mean never giving into your wants, instead try to enjoy yourself responsibly with your money.";
            return;
        }
    }

    public void AffectFinancialSecurity()
    {
        //assuming that pet ideal security is $100 more than monthly payable
        float safetyNet = FinancialAccount.Instance.getMonthlyPayable + 100;
        financialSecurity = FinancialAccount.Instance.getCurrentBalance / safetyNet;
        if (financialSecurity <= 0)
        {
            GameOver();
            Endscreen.Instance.endText.text = "GAME OVER \n Your financial security hit 0. Seems like you were being a bit too frivilous with your expenses." +
                                              "It is important to always be aware of how much money you have before you spend it. Next time, try to be more away of your expenses and budget accordingly.";
            return;
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
            Endscreen.Instance.endText.text = "GAME OVER \n Your health hit 0. Seems like you weren't taking care of yourself enough." +
                                              "Your health takes priority above all else. Remember not to neglect it even while you're taking care of your finances.";
            return;
        }
    }

    void GameOver()
    {
        UIManager.Instance.Open(GameUIID.EndScreen);
        Time.timeScale = 0f; 
    }
}
