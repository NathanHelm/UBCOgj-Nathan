using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth _instance;
    //singleton pattern! YAY
    public static PlayerHealth Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PlayerHealth>();
            }
            return _instance;
        }
    }
    [SerializeField]
    TextMeshProUGUI textM;
    public int health;
    [SerializeField]
    GameObject pause;
    private void ShowText()
    {
        textM.text = "Health:" + health ;
    }
    private void Update()
    {
        ShowText();
        if(health <= 0)
        {
            Debug.Log("GameOver");
            pause.SetActive(true);
        }
    }
    private void OnEnable()
    {
        health = 30;
    }

}
