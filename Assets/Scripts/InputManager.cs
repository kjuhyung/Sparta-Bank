using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public enum FuncType { Deposit, Withdraw }
    public FuncType type;

    [SerializeField] private MoneyManager moneyManager;

    private TMP_InputField depositInput;
    private TMP_InputField withdrawInput;

    private void Awake()
    {
        switch(type)
        {
            case FuncType.Deposit:
                depositInput = GetComponent<TMP_InputField>();
                break;
            case FuncType.Withdraw: 
                withdrawInput = GetComponent<TMP_InputField>();
                break;
        }
    }

    public void BtnClick()
    {
        switch (type)
        {
            case FuncType.Deposit:
                int depositAmount = int.Parse(depositInput.text);
                if (moneyManager.cashAmount < depositAmount)
                {
                    moneyManager.lackPanel.SetActive(true);
                    return;
                }
                else
                {
                    moneyManager.cashAmount -= depositAmount;
                    moneyManager.banlanceAmount += depositAmount;
                }
                break;

            case FuncType.Withdraw:
                int withdrawAmount = int.Parse(withdrawInput.text);
                if (moneyManager.banlanceAmount < withdrawAmount)
                {
                    moneyManager.lackPanel.SetActive(true);
                    return;
                }
                else
                {
                    moneyManager.cashAmount += withdrawAmount;
                    moneyManager.banlanceAmount -= withdrawAmount;
                }
                break;
        }
    }    
}
