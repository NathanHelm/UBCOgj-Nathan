using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeGun : Gun
{
    void OnEnable()
    {
        AmmoManager.Instance.ammo *= 10;
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
        for (int i = 0; i < 20; i++)
        {
            yield return (0.3f);

            Instantiate(bullet);
        }
        yield return null;
        //   Debug.Log("m");


    }
}
