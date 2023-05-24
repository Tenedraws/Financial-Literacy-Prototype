using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ButtonBehavior")]
public class ButtonBehavior : ScriptableObject
{
    public string Name;
    public string Description;

    public float moneyAffect;
    public expenseType expenseType;
    public bool gain;

    public float happinessAffect;
    public float financialSecurityAffect;
    public float healthAffect;

    [TextArea]
    public string result; 

    public void ApplyEffect()
    {
        FinancialAccount.Instance.AffectAccount(moneyAffect, gain, expenseType);
        MainUIElements.Instance.UpdateHappiness(happinessAffect);
        MainUIElements.Instance.UpdateSecurity(financialSecurityAffect);
        MainUIElements.Instance.UpdateHealth(healthAffect);
    }
}

