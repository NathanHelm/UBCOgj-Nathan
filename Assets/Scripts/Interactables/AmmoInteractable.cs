using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoInteractable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AmmoManager.Instance.ammo += 1;
            Money_Manager.Instance.money -= 1;
            Destroy(gameObject);
        }
    }
}
