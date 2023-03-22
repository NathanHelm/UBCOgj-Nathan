using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Buy_Health : Buy_Item
{
    private void OnEnable()
    {
        //  Enable();
      
        HideBox();
    }
    public override void ClaimItem()
    {
        PlayerHealth.Instance.health += 10;
    }
}
