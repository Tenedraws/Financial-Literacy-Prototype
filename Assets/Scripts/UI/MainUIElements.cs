using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIElements : Singleton<MainUIElements>
{
    [SerializeField]
    Slider happiness;
    [SerializeField]
    Slider financialSecurity;
    [SerializeField]
    Slider health;

    [SerializeField]
    Text expenses;
    Text currentBalance; 

    private void Start()
    {
        happiness.value = PetStats.Instance.getHappiness/100;
        financialSecurity.value = PetStats.Instance.getFinancialSecurity/100;
        health.value = PetStats.Instance.getHealth/100;
    }

    public void UpdateHappiness(float amount)
    {
        PetStats.Instance.AffectHappiness(amount);
        happiness.value = PetStats.Instance.getHappiness/100;
    }

    public void UpdateSecurity(float amount)
    {
        PetStats.Instance.AffectFinancialSecurity(amount);
        financialSecurity.value = PetStats.Instance.getFinancialSecurity/100;
    }

    public void UpdateHealth(float amount)
    {
        PetStats.Instance.AffectHealth(amount);
        health.value = PetStats.Instance.getHealth/100;
    }
}
