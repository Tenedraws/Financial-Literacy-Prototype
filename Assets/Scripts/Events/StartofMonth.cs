using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartofMonth : MonoBehaviour
{
    //Start of 'day' for prototype
    void Start()
    {
        FinancialAccount.Instance.AddAllowance();
    }
}
