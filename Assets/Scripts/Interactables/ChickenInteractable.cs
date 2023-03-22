using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenInteractable : MonoBehaviour
{
    private void OnEnable()
    {
        transform.position = new Vector3(0.16f, -8, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.Instance.health += 1;
            Destroy(gameObject);
        }
    }
}

