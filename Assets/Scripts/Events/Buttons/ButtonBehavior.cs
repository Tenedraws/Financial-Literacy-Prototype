using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ButtonBehavior")]
public class ButtonBehavior : ScriptableObject
{
    public string Name;
    public string Description;

    public float moneyAffect;
    public float allowanceAffect;
    public float monthlyPayableaffect; 
    public expenseType expenseType;
    public bool gain;

    public float happinessAffect;
    public float healthAffect;

    [TextArea]
    public string result; 

    public void ApplyEffect()
    {
        FinancialAccount.Instance.AffectAccount(moneyAffect, gain, expenseType);
        FinancialAccount.Instance.AffectAllowance(allowanceAffect);
        FinancialAccount.Instance.AffectMonthlyPayable(monthlyPayableaffect);
        MainUIElements.Instance.UpdateHappiness(happinessAffect);
        MainUIElements.Instance.UpdateSecurity();
        MainUIElements.Instance.UpdateHealth(healthAffect);
        UIManager.Instance.Open(GameUIID.Result);
        Results.Instance.result.text = result; 
    }
}

