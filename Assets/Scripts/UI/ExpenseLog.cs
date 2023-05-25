using UnityEngine;
using UnityEngine.UI;

public class ExpenseLog : MonoBehaviour
{
    [SerializeField]
    Text log;
    [SerializeField]
    Button closeButton;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f; 
        log.text = $"Current Balance: ${FinancialAccount.Instance.getCurrentBalance} \n" +
                   $"Loan Payable: ${FinancialAccount.Instance.getMonthlyPayable} \n \n " +
                   $"Total Expenses: ${FinancialAccount.Instance.getTotalDailyExpense} \n" +
                   $"Expenses by Category: \n" +
                   $"Food Expense: ${FinancialAccount.Instance.expenses[expenseType.food]} \n" +
                   $"Transport Expense: ${FinancialAccount.Instance.expenses[expenseType.transport]} \n" +
                   $"Entertainment Expense: ${FinancialAccount.Instance.expenses[expenseType.entertainment]} \n" +
                   $"Other Expense: ${FinancialAccount.Instance.expenses[expenseType.other]}";
        closeButton.onClick.AddListener(Close);
    }

    void Close()
    {
        Time.timeScale = 1f;
        UIManager.Instance.Close(this.gameObject);
    }
}
