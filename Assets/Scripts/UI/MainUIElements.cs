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

    public Text hour;

    [SerializeField]
    Button expenses;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        expenses.onClick.AddListener(Log);
        FinancialAccount.Instance.AddAllowance();
        PetStats.Instance.AffectFinancialSecurity();
        happiness.value = PetStats.Instance.getHappiness/100;
        financialSecurity.value = PetStats.Instance.getFinancialSecurity;
        health.value = PetStats.Instance.getHealth/100;
        hour.text = $"Time: \n {TimeTracker.Instance.hour}:00";
    }

    public void UpdateHappiness(float amount)
    {
        PetStats.Instance.AffectHappiness(amount);
        happiness.value = PetStats.Instance.getHappiness/100;
    }

    public void UpdateSecurity()
    {
        PetStats.Instance.AffectFinancialSecurity();
        if(PetStats.Instance.getFinancialSecurity >= 1)
        {
            financialSecurity.value = 1;
        }
        else
        {
            financialSecurity.value = PetStats.Instance.getFinancialSecurity; 
        }
    }

    public void UpdateHealth(float amount)
    {
        PetStats.Instance.AffectHealth(amount);
        health.value = PetStats.Instance.getHealth/100;
    }

    void Log()
    {
        Time.timeScale = 0f;
        UIManager.Instance.Open(GameUIID.Expenses);
    }
}
