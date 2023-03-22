using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Money_Manager : MonoBehaviour
{
    public static Money_Manager _instance;
    //singleton pattern! YAY
    public static Money_Manager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Money_Manager>();
            }
            return _instance;
        }
    }
    [SerializeField]
    TextMeshProUGUI textM;
    public int money;
    private void ShowText()
    {
        textM.text = "Money:" + money;
    }
    private void Update()
    {
        ShowText();
        if(money <= 0)
        {
            money = 0;
        }

    }
    private void OnEnable()
    {
        money = 100;
    }

}
