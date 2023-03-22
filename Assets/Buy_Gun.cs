using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Buy_Gun : Buy_Item
{
    BoxCollider2D[] b;

    void OnEnable()
    {
        // Enable();
        b = GameObject.Find("sb").GetComponents<BoxCollider2D>();
        HideBox();
    }
    // Start is called before the first frame update
    [SerializeField]
    GameObject gun;
    
    public override void ClaimItem()
    {
        gun.SetActive(true);
        if(amount == 200)
        {
            foreach (BoxCollider2D sb in b)
            {
                Destroy(sb);
            }
        }
    }
    

}
