using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun:MonoBehaviour
{
    private static Vector2 mousePos;
    private static Camera cam;
    private float x, y;
    public GameObject bullet;
    [HideInInspector]
    public Transform t;
    [HideInInspector]
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void OnEnable()
    {
       // StartCoroutine(Click());


    }

    // Update is called once per frame
  
    public void RotateU()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        x = FindObjectOfType<PlayerMovement>().transform.position.x - .30f;
        y = FindObjectOfType<PlayerMovement>().transform.position.y;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clic");
            if (AmmoManager.Instance.ammo > 0)
            {
                StartCoroutine(Click());
            }
        }
       // if()

        //Debug.Log("rU");
    }
    public void RotateFxU()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 180f;
        rb.rotation = angle;
        t.position = new Vector3(x, y, 0);
        //Debug.Log("rFU");
//        Debug.Log(mousePos);
     
    }
    public virtual IEnumerator Click()
    {
     Instantiate(bullet);
     


     yield return null;
    }



}

