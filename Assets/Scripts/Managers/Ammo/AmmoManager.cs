using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoManager : MonoBehaviour
{
    public static AmmoManager _instance;
    //singleton pattern! YAY
    public static AmmoManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AmmoManager>();
            }
            return _instance;
        }
    }
    [SerializeField]
    TextMeshProUGUI textM;
    public int ammo;
    private void ShowText()
    {
        textM.text = "Ammo:" + ammo;
      
    }
    private void Update()
    {
        ShowText();
       
    }
    private void OnEnable()
    {
        ammo = 300;
    }


}
