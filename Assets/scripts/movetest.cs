using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest : MonoBehaviour
{
    public bool bot;
    void Start()
    {

    }
    public Rigidbody2D mball;

    public Vector2 direction;
    public float moves;
    public void FixedUpdate()
    {
        if (bot == false)
        {
            if (direction.sqrMagnitude != 0)
            {
                rigiborya.AddForce(direction * moves);
            }
        }
        else
        {
            if (mball.velocity.x <= 0)
            {
                transform.position = new Vector3(transform.position.x, mball.position.y, transform.position.z);
            }
        }
    }
    public Rigidbody2D rigiborya;
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else
        {
            direction = Vector2.zero;
        }

    }
}
