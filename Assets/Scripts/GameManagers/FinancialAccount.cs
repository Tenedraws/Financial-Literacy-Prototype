using System.Collections.Generic;
using UnityEngine;

public class FinancialAccount : Singleton<FinancialAccount>
{
    public float allowance = 200;
    float currentBalance = 0;
    public float getCurrentBalance => currentBalance;

    float totalDailyExpense;
    public float getTotalDailyExpense => totalDailyExpense;
    public Dictionary<expenseType, float> expenses = new Dictionary<expenseType, float>();

    float monthlyPayable = 100; 
    public float getMonthlyPayable => monthlyPayable;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        //TODO find a better way to initiliaze in future
        expenses[expenseType.food] = 0;
        expenses[expenseType.transport] = 0;
        expenses[expenseType.entertainment] = 0;
        expenses[expenseType.other] = 0;
    }

    public void AddAllowance()
    {
        currentBalance += allowance;
    }

    public void AffectAllowance(float amount)
    {
        allowance += amount; 
    }

    public void AffectAccount(float amount, bool gain, expenseType type = expenseType.other)
    {
        currentBalance += amount;

        if (!gain)
        {
            var expense = Mathf.Abs(amount);
            totalDailyExpense += expense;
            expenses[type] += expense;
        }
    }

    public void AffectMonthlyPayable(float amount)
    {
        monthlyPayable += amount; 
    }

    public void PayMonthlyPayable()
    {
        if (currentBalance >= monthlyPayable)
        {
            currentBalance -= monthlyPayable;
        }
        else
        {
            UIManager.Instance.Open(GameUIID.EndScreen);
            Endscreen.Instance.endText.text = "GAME OVER \n You didn't manage to pay off your monthly fee. Try to be more aware of your finances and spendings and always keep future costs in mind.";
            return; 
        }
        
    }
}

public enum expenseType
{
    food,
    transport,
    entertainment,
    other
}
