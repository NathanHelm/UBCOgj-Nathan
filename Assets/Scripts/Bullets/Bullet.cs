using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float speed;
    public Rigidbody2D rb;
    public float distance;
    public Vector3 mousePos;
    public Camera cam;
    private Vector2 lookDir;
    private int amount;
    float timer = 3;
    private void OnEnable()
    {
        float x = FindObjectOfType<PlayerMovement>().transform.position.x - .40f;
        float y = FindObjectOfType<PlayerMovement>().transform.position.y;
        transform.position = new Vector3(x,y,0);
        
        //rbp = FindObjectOfType<PlayerMovement>().GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        BulletAngle();
        AmmoManager.Instance.ammo -= 1;
        if(AmmoManager.Instance.ammo < 0)
        {
            AmmoManager.Instance.ammo = 0;
        }
        StartCoroutine(BulletTime());



    }
    private void Update()
    {
       
    }
    private void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        Force();
      
    }
    private void BulletAngle()
    {
       
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        lookDir = mousePos - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) - Mathf.PI;
        rb.rotation = angle;
        
    }
    public void Force()
    {
        rb.AddForce(lookDir * distance);
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Enemy")
        {
            Money_Manager.Instance.money += 2;
        }
    }
    IEnumerator BulletTime()
    {
        yield return new WaitForSeconds(4f);
            Destroy(gameObject);
            yield return null;
        
    }

}
