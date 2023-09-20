using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cashAmountTxt;
    [SerializeField] private TextMeshProUGUI banlanceAmountTxt;

    [SerializeField] public GameObject lackPanel;
    [SerializeField] public GameObject wrongInputPanel;

    private int cashAmount; 
    private int banlanceAmount; 


    private void Awake()
    {
        cashAmount = 100000;
        banlanceAmount = 50000;
    }

    public void Deposit(int amount)
    {     
        if(cashAmount < amount)
        {
            lackPanel.SetActive(true);
            return;
        }
        cashAmount -= amount;
        banlanceAmount += amount;
    }

    public void Withdraw(int amount)
    {
        if (banlanceAmount < amount)
        {
            lackPanel.SetActive(true);
            return;
        }
        banlanceAmount -= amount;
        cashAmount += amount;
    }

    private void LateUpdate()
    {
        // 0 �� �� Null �� �ǹ����� ����� �ȵǴ� ����
        // cashAmountTxt.text = string.Format("{0:#,###}", cashAmount);
        cashAmountTxt.text = cashAmount.ToString("N0");
        banlanceAmountTxt.text = banlanceAmount.ToString("N0");
    }
}

