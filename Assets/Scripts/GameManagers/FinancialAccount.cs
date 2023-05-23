using System.Collections.Generic;
using UnityEngine;

public class FinancialAccount : Singleton<FinancialAccount>
{
    public float allowance;
    float currentBalance;
    public float getCurrentBalance => currentBalance;

    float totalDailyExpense;
    public float getTotalDailyExpense => totalDailyExpense;
    public Dictionary<expenseType, float> expenses = new Dictionary<expenseType, float>();

    protected override void Awake()
    {
        base.Awake();
    }

    public void AffectAccount(float amount, bool gain, expenseType type = expenseType.other)
    {
        currentBalance += amount;

        if (!gain)
        {
            if (!expenses.ContainsKey(type))
            {
                expenses[type] = 0;
            }

            var expense = Mathf.Abs(amount);
            totalDailyExpense += expense;
            expenses[type] += expense;
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
