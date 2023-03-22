using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGun : Gun
{

    // Start is called before the first frame update
    void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        t = this.transform;
       //cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateU();
    }
    private void FixedUpdate()
    {
        RotateFxU();
    }
    public override IEnumerator Click()
    {
        return base.Click();
    }
}
