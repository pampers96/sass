using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedbounce : MonoBehaviour
{
    public float bounceforce = 500;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        mballl v = collision.gameObject.GetComponent<mballl>();
        if (v != null)
        {
            Vector2 norm = collision.GetContact(0).normal;
            norm *= -1;
            v.GetComponent<Rigidbody2D>().AddForce(norm * bounceforce, ForceMode2D.Impulse);

        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
