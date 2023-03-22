using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public abstract class Buy_Item : MonoBehaviour
{

    public GameObject textBox;
    public TextMeshProUGUI textP;
    public int amount;
    bool isEnabled = false ;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ShowBox();
            isEnabled = true;
            Debug.Log("enter");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        HideBox();
        isEnabled = false;
    }

    // Start is called before the first frame update
    void ShowBox()
    {
        textBox.SetActive(true);
        textP.text = "Buy? Amount =" + amount + "\n" + "Press Enter To Buy";
       
        
    }
  
    private void Update()
    {
        if(isEnabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (amount <= Money_Manager.Instance.money)
                {
                    Money_Manager.Instance.money -= amount;
                    ClaimItem();
                    Debug.Log("claim");
                }
                else
                {
                    textP.text = "Your Broke."+"\nkill ghosts to get money!";
                }
            }

        }
    }

    // Update is called once per frame
    public void HideBox()
    {
        textBox.SetActive(false);
    }
    public abstract void ClaimItem();
    
}
