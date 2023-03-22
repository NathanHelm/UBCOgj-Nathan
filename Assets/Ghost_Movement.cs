using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Movement : MonoBehaviour
{
    Rigidbody2D rb,playerRb;
    [SerializeField] float speed;
    SpriteRenderer s;
    float r; 
    
    // Start is called before the first frame update
    void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        s = GetComponent<SpriteRenderer>();
        r = Random.Range(4f, 6f); 
        transform.localScale = new Vector3(r, r, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRb = FindObjectOfType<PlayerMovement>().GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
        Vector2 lookDir = playerRb.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) - Mathf.PI;
        rb.rotation = angle;
        rb.AddForce(lookDir * speed);
        if (Mathf.Abs(Mathf.RoundToInt(rb.velocity.x)) > 3 || Mathf.Abs(Mathf.RoundToInt(rb.velocity.y))>3)
        {
            s.color = new Color(255, 0, 0, 255);
        }
        else
        {
            s.color = new Color(255, 255, 255, 255);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerHealth.Instance.health -= 1 + 1 * Mathf.Abs(Mathf.RoundToInt(rb.velocity.x*2 + rb.velocity.y*2));
            //            Debug.Log(rb.velocity.x);
            InvokeRepeating("ConstantDamage", 2, 30);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       // CancelInvoke();
    }
    void ConstantDamage()
    {
        PlayerHealth.Instance.health -= 1;
        Debug.Log("damage");
    }
}
