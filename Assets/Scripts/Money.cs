using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cashAmountTxt;
    [SerializeField] private TextMeshProUGUI banlanceAmountTxt;

    int cashAmount; 
    int banlanceAmount; 


    private void Awake()
    {
        cashAmount = 100000;
        banlanceAmount = 50000;
    }

    public void Deposit(int amount)
    {     
        if(cashAmount < amount)
        {
            // TODO
            // �ܾ� ���� ȭ�� ����
            return;
        }
        cashAmount -= amount;
        banlanceAmount += amount;
    }

    private void LateUpdate()
    {
        cashAmountTxt.text = cashAmount.ToString();
        banlanceAmountTxt.text = banlanceAmount.ToString();
    }
}

