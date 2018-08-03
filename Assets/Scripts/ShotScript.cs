using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

    public float shotSpeed;
    public float damage;

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * shotSpeed * Time.deltaTime;
    }

    void onBecomeInvisible()
    {
        // TODO: Optimize so it gets deactivated and put in a queue to use later
        Destroy(this);
    }
}
