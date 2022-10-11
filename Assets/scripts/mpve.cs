using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mpve : MonoBehaviour
{
    void Start()
    {
        
    }
    public Vector2 direction;
    public float moves;
    public void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rigiborya.AddForce(direction * moves);
        }
    }
    public Rigidbody2D rigiborya;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            direction = Vector2.down ;
        }
        else if (Input.GetMouseButton(1))
        {
            direction = Vector2.up;
        }
        else
        {
            direction = Vector2.zero;
        }

    }
}
